/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;

using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Cavebox
{
	/// <summary>
	/// Description of Model.
	/// </summary>
	static class Model
	{		
		public static SQLiteConnection db {get; set;}

		public static Boolean Connect(string connectionString)
		{
			try
			{
				db = new SQLiteConnection(connectionString).OpenAndReturn();
				return true;
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
				return false;
			}

		}
		
		public static string Status()
		{
			return FetchOne("PRAGMA integrity_check");
		}
		
		public static string SQLiteVersion()
		{
			return db.ServerVersion;
		}
		
		public static void Install()
		{
			try
			{
				SQLiteCommand cm = db.CreateCommand();
				cm.CommandText = "CREATE TABLE cakebox (id INTEGER PRIMARY KEY, label TEXT NOT NULL);";
				cm.ExecuteNonQuery();
				cm.CommandText = "CREATE TABLE disc (id INTEGER PRIMARY KEY, cid INTEGER DEFAULT 0, label TEXT NOT NULL, files TEXT NOT NULL, filesno INTEGER DEFAULT 0, added INTEGER NOT NULL DEFAULT 0);";
				cm.ExecuteNonQuery();
				cm.Dispose();
				Console.WriteLine(Lang.GetString("_installing"));
			}
			catch
			{
				Console.WriteLine(Lang.GetString("_installed"));
			}
		}

		public static void RebuildFileCounters()
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
					up.ExecuteNonQuery();
				}
				transaction.Commit();
				row.Close();
				cm.Dispose();
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
			}
		}
		
		public static List<Index> FetchCakeboxes(string filter = null)
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
		
		public static List<Index> FetchDiscsByCakeboxId(string id, string filter = null, int orderBy = 1, int orderWay = 0)
		{
			List<Index> list = new List<Index>();
			try
			{
				SQLiteCommand cm = db.CreateCommand();
				string orderClause = null;
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
				string label;
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
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
			}			
			return list;
		}
		
		public static string FetchDiscLabelById(int id)
		{
			return FetchOne("SELECT label FROM disc WHERE id = " + id);
		}
		
		public static object[] FetchFilesListByDiscId(string id)
		{	
			object[] result = new object[3];
			try
			{
				SQLiteCommand cm = db.CreateCommand();
				cm.CommandText = "SELECT files, filesno, added FROM disc WHERE id = "+ id;
				SQLiteDataReader row = cm.ExecuteReader();

				while(row.Read())
				{
					result[0] = row.GetString(0);
					result[1] = row.GetInt32(1);
					result[2] = row.GetInt32(2);
				}
				row.Close();
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
			}
			return result;
		}
		
		public static void SaveCakebox(string label, int id = 0)
		{
			Dictionary<string, string> data = new Dictionary<string, string>();
			data.Add("label", label);
			if(id > 0)
			{
				Update("cakebox", data, "id = " + id);
			}
			else
			{
				Insert("cakebox", data);
				
			}
		}
		
		public static void DeleteCakebox(int id)
		{
			if(id > 0)
			{
				Execute("Delete FROM cakebox WHERE id = " + id);
			}
		}
		
		public static void UpdateDisc(int id, int cid, string label)
		{
			Dictionary<string, string> data = new Dictionary<string, string>();
			data.Add("cid", cid.ToString());
			data.Add("label", label);
			Update("disc", data, "id = " + id);
		}
		
		public static void AddDisc(string label, string files, string filesno, string cid, string added)
		{
			Dictionary<string, string> data = new Dictionary<string, string>();
			data.Add("cid", cid);
			data.Add("label", label);
			data.Add("files", files);
			data.Add("filesno", filesno);
			data.Add("added", added);
			Insert("disc", data);
		}
		
		public static void DeleteDisc(int id)
		{
			if(id > 0)
			{
				Execute("Delete FROM disc WHERE id = " + id);
			}
		}
		
		public static void MoveDiscs(int target, List<int> discs)
		{
			Dictionary<string, string> data = new Dictionary<string, string>();
			data.Add("cid", target.ToString());
			Update("disc", data, "id IN (" + String.Join(", ", discs) + ")");
		}

		public static int GetTotalCakeboxes()
		{
			return Convert.ToInt32(FetchOne("SELECT COUNT(*) AS total FROM cakebox"));
		}
		
		public static int GetTotalDiscs()
		{
			return Convert.ToInt32(FetchOne("SELECT COUNT(*) AS total FROM disc"));
		}
		
		public static int GetTotalFiles()
		{
			return Convert.ToInt32(FetchOne("SELECT COALESCE(SUM(filesno), 0) AS total FROM disc"));
		}
		
		public static void Update(string table, Dictionary<string, string> data, string where)
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
		
		public static void Insert(string table, Dictionary<string, string> data)
		{
			Insert(table, new List<string>(data.Keys), new List<string>(data.Values));
		}
		
		public static void Insert(string table, List<string> columns, List<string> values)
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
		
		private static void Execute(string sql)
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
		
		private static string FetchOne(string sql)
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
		
		public static void Vacuum()
		{
			Execute("VACUUM");
		}
	}
}