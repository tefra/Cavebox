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
			catch
			{
				return false;
			}
		}
		
		public static void Close()
		{
			db.Close();
		}
		
		public static string Status()
		{
			return ExecuteScalar("PRAGMA integrity_check");
		}
		
		public static string SQLiteVersion()
		{
			return db.ServerVersion;
		}
		
		public static void Vacuum()
		{
			ExecuteNonQuery("VACUUM");
		}
		
		public static void Install()
		{
			try
			{
				SQLiteCommand c = CreateCommand("CREATE TABLE cakebox (id INTEGER PRIMARY KEY, label TEXT NOT NULL);");
				c.ExecuteNonQuery();
				c.CommandText = "CREATE TABLE disc (id INTEGER PRIMARY KEY, cid INTEGER DEFAULT 0, label TEXT NOT NULL, files TEXT NOT NULL, filesno INTEGER DEFAULT 0, added INTEGER NOT NULL DEFAULT 0);";
				c.ExecuteNonQuery();
				c.Dispose();
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
				SQLiteCommand c = CreateCommand("SELECT id, files FROM disc WHERE 1");
				SQLiteCommand u = CreateCommand("Update disc SET filesno = ? WHERE id = ?");
				SQLiteParameter id = new SQLiteParameter();
				SQLiteParameter filesno = new SQLiteParameter();
				u.Parameters.Add(filesno);
				u.Parameters.Add(id);
				SQLiteDataReader r = c.ExecuteReader();
				while (r.Read())
				{
					id.Value = r.GetInt32(0);
					filesno.Value = r.GetString(1).Split('\n').Length;
					u.ExecuteNonQuery();
				}
				transaction.Commit();
				r.Close();
				c.Dispose();
				u.Dispose();
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
				
				string sql = (filter == null) ?
					"SELECT id, label FROM cakebox ORDER BY label COLLATE NOCASE ASC" :
					"SELECT c.id, c.label FROM cakebox AS c LEFT JOIN disc AS d on d.cid = c.id WHERE files LIKE '" + filter + "' GROUP BY c.id";

				SQLiteCommand c = CreateCommand(sql);
				SQLiteDataReader r = c.ExecuteReader();
				while (r.Read())
				{
					list.Add(new Index(r.GetInt32(0), r.GetString(1)));
				}
				r.Close();
				c.Dispose();
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
				
				string sql = (filter != null) ?
					"SELECT id, label, filesno FROM disc WHERE cid = "+ id+" AND files LIKE '" + filter + "' ORDER BY "+orderClause :
					"SELECT id, label, filesno FROM disc WHERE cid = "+ id+" ORDER BY "+orderClause;

				SQLiteCommand c = CreateCommand(sql);
				SQLiteDataReader r = c.ExecuteReader();
				string label;
				int diskId;
				while (r.Read())
				{
					label = r.GetString(1);
					diskId = r.GetInt32(0);
					
					if(label.ToUpper().Equals("MOVIES") || orderBy == 0)
					{
						label = "#" + diskId + " - " + label;
					}
					if(orderBy == 2)
					{
						label += " (" + r.GetInt32(2) + ")";
					}
					list.Add(new Index(diskId, label));
				}
				r.Close();
				c.Dispose();
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
			}
			return list;
		}
		
		public static string FetchDiscLabelById(int id)
		{
			return ExecuteScalar("SELECT label FROM disc WHERE id = " + id);
		}
		
		public static object[] FetchFilesListByDiscId(string id)
		{
			object[] result = new object[3];
			try
			{
				SQLiteCommand c = CreateCommand("SELECT files, filesno, added FROM disc WHERE id = "+ id);
				SQLiteDataReader r = c.ExecuteReader();
				while(r.Read())
				{
					result[0] = r.GetString(0);
					result[1] = r.GetInt32(1);
					result[2] = r.GetInt32(2);
				}
				r.Close();
				c.Dispose();
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
				ExecuteNonQuery("Delete FROM cakebox WHERE id = " + id);
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
				ExecuteNonQuery("Delete FROM disc WHERE id = " + id);
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
			return Convert.ToInt32(ExecuteScalar("SELECT COUNT(*) AS total FROM cakebox"));
		}
		
		public static int GetTotalDiscs()
		{
			return Convert.ToInt32(ExecuteScalar("SELECT COUNT(*) AS total FROM disc"));
		}
		
		public static int GetTotalFiles()
		{
			return Convert.ToInt32(ExecuteScalar("SELECT COALESCE(SUM(filesno), 0) AS total FROM disc"));
		}
		
		public static void Update(string table, Dictionary<string, string> data, string where)
		{
			try
			{
				List<string> sets = new List<string>();
				SQLiteCommand c = db.CreateCommand();
				foreach (KeyValuePair<string, string> pair in data)
				{
					sets.Add(String.Format("{0} = @{0}", pair.Key));
					c.Parameters.Add(new SQLiteParameter("@"+pair.Key, pair.Value));
				}
				c.CommandText = String.Format("UPDATE {0} SET {1} WHERE {2}", table, String.Join(", ", sets), where);
				c.ExecuteNonQuery();
				c.Dispose();
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
			SQLiteCommand c = CreateCommand(String.Format("INSERT INTO {0} ({1}) VALUES (@{2})", table, String.Join(", ", columns), String.Join(", @", columns)));
			for(int i = 0; i < columns.Count; i++)
			{
				c.Parameters.Add(new SQLiteParameter("@"+columns[i], values[i]));
			}
			c.ExecuteNonQuery();
			c.Dispose();
		}
		
		private static void ExecuteNonQuery(string sql)
		{
			try
			{
				SQLiteCommand c = CreateCommand(sql);
				c.ExecuteNonQuery();
				c.Dispose();
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
			}
		}
		
		private static string ExecuteScalar(string sql)
		{
			try
			{
				SQLiteCommand c = CreateCommand(sql);
				Object res = c.ExecuteScalar();
				c.Dispose();
				return res.ToString();
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
				return null;
			}
		}
		
		private static SQLiteCommand CreateCommand(string sql)
		{
			SQLiteCommand c = db.CreateCommand();
			c.CommandText = sql;
			return c;
		}
	}
}