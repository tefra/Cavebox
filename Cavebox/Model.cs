/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Cavebox
{
	/// <summary>
	/// Description of Model.
	/// </summary>
	public class Model
	{
		private static Model instance = new Model();
		
		public static Model Instance
		{
			get { return instance; }
		}
		
		public SQLiteConnection db {get; set;}

		private Model()
		{
			db = null;
			try
			{
				String dbConnection = "Data Source=data.db";
				db = new SQLiteConnection(dbConnection);
				db.Open();
				Console.WriteLine("Starting up SQLite " + db.ServerVersion + ": " + fetchOne("PRAGMA integrity_check"));
			}
			catch
			{
				MessageBox.Show("Database connection failed!", "Cavebox", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				Application.Exit();
			}
			
			try
			{
				SQLiteCommand cm = db.CreateCommand();
				cm.CommandText = "CREATE TABLE cakebox (id INTEGER PRIMARY KEY, label TEXT NOT NULL);";
				cm.ExecuteNonQuery();
				cm.CommandText = "CREATE TABLE disc (id INTEGER PRIMARY KEY, cid INTEGER DEFAULT 0, label TEXT NOT NULL, files TEXT NOT NULL, filesno INTEGER DEFAULT 0, added INTEGER NOT NULL DEFAULT 0);";
				cm.ExecuteNonQuery();
				cm.Dispose();
				Console.WriteLine("DB Schema Was Created");
			}
			catch
			{
				Console.WriteLine("Valid DB Schema Found");
			}
		}

		public void rebuildFileCounters()
		{
			try
			{
				SQLiteTransaction transaction = db.BeginTransaction();
				SQLiteCommand cm = db.CreateCommand();
				SQLiteCommand up = db.CreateCommand();
				
				cm.CommandText = "SELECT id, files FROM disc WHERE 1";
				up.CommandText = "Update disc SET filesno = ? WHERE id = ?";
				SQLiteParameter id = new SQLiteParameter();
				SQLiteParameter filesno = new SQLiteParameter();

				up.Parameters.Add(filesno);
				up.Parameters.Add(id);

				SQLiteDataReader row = cm.ExecuteReader();
				while (row.Read())
				{
					id.Value = row.GetInt32(0);
					filesno.Value = row.GetString(1).Split('\n').Length;
					Console.WriteLine("Disc #" + id.Value + " = " + filesno.Value);
					up.ExecuteNonQuery();
				}
				transaction.Commit();
				row.Close();
				cm.Dispose();
				up.Dispose();
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
			}
		}
		
		public List<Index> fetchCakeboxes(String filter = null)
		{
			List<Index> list = new List<Index>();
			try
			{
				SQLiteCommand cm = db.CreateCommand();
				if(filter == null)
				{
					cm.CommandText = "SELECT id, label FROM cakebox ORDER BY label COLLATE NOCASE ASC";
				}
				else
				{
					cm.CommandText = "SELECT c.id, c.label FROM cakebox AS c LEFT JOIN disc AS d on d.cid = c.id WHERE files LIKE '" + filter + "' GROUP BY c.id ";
				}
				
				SQLiteDataReader row = cm.ExecuteReader();
				while (row.Read())
				{
					list.Add(new Index(row.GetInt32(0), row.GetString(1)));
				}
				row.Close();
				cm.Dispose();
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
			}
			return list;
		}
		
		public List<Index> fetchDiscsByCakeboxId(String id, String filter = null, int orderBy = 1, int orderWay = 0)
		{
			List<Index> list = new List<Index>();
			try
			{
				SQLiteCommand cm = db.CreateCommand();
				String orderClause = null;
				switch(orderBy)
				{
					case 0:
						orderClause = "id";
						break;
					case 1:
						orderClause = "label COLLATE NOCASE";
						break;
					case 2:
						orderClause = "filesno";
						break;
				}
				orderClause += (orderWay == 0) ? " ASC" : " DESC";
				
				if(filter != null)
				{
					cm.CommandText = "SELECT id, label, filesno FROM disc WHERE cid = "+ id+" AND files LIKE '" + filter + "' ORDER BY "+orderClause;
				}
				else
				{
					cm.CommandText = "SELECT id, label, filesno FROM disc WHERE cid = "+ id+" ORDER BY "+orderClause;
				}
				
				SQLiteDataReader row = cm.ExecuteReader();
				String label;
				int diskId;
				while (row.Read())
				{
					label = row.GetString(1);
					diskId = row.GetInt32(0);
					
					if(label.ToUpper().Equals("MOVIES") || orderBy == 0)
					{
						label = "#" + diskId + " - " + label;
					}
					if(orderBy == 2)
					{
						label += " (" + row.GetInt32(2) + ")";
					}
					list.Add(new Index(diskId, label));
				}
				
				row.Close();
				cm.Dispose();
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
			}
			return list;
		}
		
		public string fetchDiscLabelById(int id)
		{
			return fetchOne("SELECT label FROM disc WHERE id = " + id);
		}
		
		public Tuple<string, int, int> fetchFilesListByDiscId(String id)
		{
			try
			{
				SQLiteCommand cm = db.CreateCommand();
				cm.CommandText = "SELECT files, filesno, added FROM disc WHERE id = "+ id;
				SQLiteDataReader row = cm.ExecuteReader();

				while(row.Read())
				{
					return new Tuple<string, int, int>(row.GetString(0), row.GetInt32(1), row.GetInt32(2));
				}
				row.Close();
				cm.Dispose();
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
				
			}
			
			return new Tuple<string, int, int>(null, 0, 0);
		}
		
		public void saveCakebox(String label, int id = 0)
		{
			Dictionary<string, string> data = new Dictionary<string, string>();
			data.Add("label", label);
			if(id > 0)
			{
				update("cakebox", data, "id = " + id);
			}
			else
			{
				insert("cakebox", data);
				
			}
		}
		
		public void deleteCakebox(int id)
		{
			if(id > 0)
			{
				query("Delete FROM cakebox WHERE id = " + id);
			}
		}
		
		public void updateDisc(int id, int cid, string label)
		{
			Dictionary<string, string> data = new Dictionary<string, string>();
			data.Add("cid", cid.ToString());
			data.Add("label", label);
			update("disc", data, "id = " + id);
		}
		
		public void addDisc(string label, string files, string filesno, string cid, string added)
		{
			Dictionary<string, string> data = new Dictionary<string, string>();
			data.Add("cid", cid);
			data.Add("label", label);
			data.Add("files", files);
			data.Add("filesno", filesno);
			data.Add("added", added);
			insert("disc", data);
		}
		
		public void deleteDisc(int id)
		{
			if(id > 0)
			{
				query("Delete FROM disc WHERE id = " + id);
			}
		}
		
		public void moveDiscs(int target, List<int> discs)
		{
			Dictionary<string, string> data = new Dictionary<string, string>();
			data.Add("cid", target.ToString());
			update("disc", data, "id IN (" + String.Join(", ", discs) + ")");
		}

		public int getTotalCakeboxes()
		{
			return Convert.ToInt32(fetchOne("SELECT COUNT(*) AS total FROM cakebox"));
		}
		
		public int getTotalDiscs()
		{
			return Convert.ToInt32(fetchOne("SELECT COUNT(*) AS total FROM disc"));
		}
		
		public int getTotalFiles()
		{
			return Convert.ToInt32(fetchOne("SELECT COALESCE(SUM(filesno), 0) AS total FROM disc"));
		}
		
		public void update(string table, Dictionary<string, string> data, string where)
		{
			try
			{
				List<string> sets = new List<string>();
				SQLiteCommand cm = db.CreateCommand();
				foreach (KeyValuePair<string, string> pair in data)
				{
					sets.Add(String.Format("{0} = @{0}", pair.Key));
					cm.Parameters.Add(new SQLiteParameter("@"+pair.Key, pair.Value));
				}
				cm.CommandText = String.Format("UPDATE {0} SET {1} WHERE {2}", table, String.Join(", ", sets), where);
				cm.ExecuteNonQuery();
				cm.Dispose();
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
			}
		}
		
		public void insert(string table, Dictionary<string, string> data)
		{
			insert(table, new List<string>(data.Keys), new List<string>(data.Values));
		}
		
		public void insert(String table, List<string> columns, List<string> values)
		{
			SQLiteCommand cm = db.CreateCommand();
			cm.CommandText = String.Format("INSERT INTO {0} ({1}) VALUES (@{2})", table, String.Join(", ", columns), String.Join(", @", columns));
			for(int i = 0; i < columns.Count; i++)
			{
				cm.Parameters.Add(new SQLiteParameter("@"+columns[i], values[i]));
			}
			cm.ExecuteNonQuery();
			cm.Dispose();
		}
		
		private void query(string sql)
		{
			try
			{
				SQLiteCommand cm = db.CreateCommand();
				cm.CommandText = sql;
				cm.ExecuteNonQuery();
				cm.Dispose();
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
			}
		}
		
		private String fetchOne(String sql)
		{
			try
			{
				SQLiteCommand cm = new SQLiteCommand(db);
				cm.CommandText = sql;
				Object res = cm.ExecuteScalar();
				cm.Dispose();
				return res.ToString();
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
				return null;
			}
		}
		
		public void vacuum()
		{
			query("VACUUM");
		}
	}
}