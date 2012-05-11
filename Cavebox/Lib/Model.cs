/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Cavebox.Lib
{
	/// <summary>
	/// Database model to do almost all db tasks
	/// </summary>
	static class Model
	{
		/// <summary>
		/// Magic get set SQLiteConnection
		/// </summary>
		public static SQLiteConnection db {get; set;}

		/// <summary>
		/// Connect to sqlite database and return result
		/// </summary>
		/// <param name="connectionString">Connection URL string</param>
		/// <returns>True or False based on the result of trying to establish a new connection</returns>
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
		
		/// <summary>
		/// Close database connection
		/// </summary>
		public static void Close()
		{
			db.Close();
		}
		
		/// <summary>
		/// Run integrity check and return result
		/// </summary>
		/// <returns>Ok: If everything looks right a catastrophic exception i guess if not</returns>
		public static string Status()
		{
			return ExecuteScalar("PRAGMA integrity_check");
		}
		
		/// <summary>
		/// Return sqlite version
		/// </summary>
		/// <returns>SQLite Server Version ex: 3.7.11</returns>
		public static string SQLiteVersion()
		{
			return db.ServerVersion;
		}
		
		/// <summary>
		/// Compilation options for SQLite
		/// </summary>
		/// <returns></returns>
		public static DataTable SQLiteOptions()
		{
			return Fetch("PRAGMA compile_options");
		}
		
		/// <summary>
		/// Execute vacuum command
		/// </summary>
		public static void Vacuum()
		{
			ExecuteNonQuery("VACUUM");
		}
		
		/// <summary>
		/// Create tables schema if it doesn't exist
		/// </summary>
		public static void Install()
		{
			ExecuteNonQuery(
				"CREATE TABLE IF NOT EXISTS cakebox ("
				+ " id INTEGER PRIMARY KEY, "
				+ " label TEXT NOT NULL);"
				+ "CREATE TABLE IF NOT EXISTS disc ("
				+ " id INTEGER PRIMARY KEY, "
				+ " cid INTEGER DEFAULT 0, "
				+ " label TEXT NOT NULL, "
				+ " files TEXT NOT NULL, "
				+ " filesno INTEGER DEFAULT 0, "
				+ " added INTEGER NOT NULL DEFAULT 0);"
				+ "CREATE INDEX IF NOT EXISTS disc_cid ON disc (cid ASC);"
				+ "CREATE INDEX IF NOT EXISTS disc_files ON disc (files ASC);"
			);
		}
		
		/// <summary>
		/// Drop tables cakebox and disc
		/// </summary>
		public static void DropTables()
		{
			ExecuteNonQuery("DROP TABLE cakebox");
			ExecuteNonQuery("DROP TABLE disc");
		}
		
		/// <summary>
		/// Rebuild file counters
		/// </summary>
		public static void RebuildFileCounters()
		{
			try
			{
				SQLiteTransaction t = db.BeginTransaction();
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
				t.Commit();
				r.Close();
				c.Dispose();
				u.Dispose();
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
			}
		}
		
		/// <summary>
		/// Custom ToLower Sqlite Command for proper search LIKE results
		/// </summary>
		[SQLiteFunction(Name = "ToLower", Arguments = 1, FuncType = FunctionType.Scalar)]
		public class ToLower: SQLiteFunction
		{
			public override object Invoke(object[] args)
			{
				return args[0].ToString().ToLower();
			}
		}
		
		/// <summary>
		/// Fetch cakeboxes list with or without filter
		/// </summary>
		/// <param name="filter">A prepared string to filter results ex: %criminal%</param>
		/// <returns>A list of the matched cakeboxes</returns>
		public static List<Identity> FetchCakeboxes(string filter = null)
		{
			List<Identity> list = new List<Identity>();
			try
			{
				string sql = (filter == null) ?
					"SELECT id, label FROM cakebox ORDER BY label COLLATE NOCASE ASC" :
					"SELECT c.id, c.label FROM cakebox AS c LEFT JOIN disc AS d on d.cid = c.id WHERE ToLower(d.files) LIKE '" + filter + "' GROUP BY c.id";

				SQLiteCommand c = CreateCommand(sql);
				SQLiteDataReader r = c.ExecuteReader();
				while (r.Read())
				{
					list.Add(new Identity(r.GetInt32(0), r.GetString(1)));
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
		
		/// <summary>
		/// Fetch discs list with or without filter with custom sort
		/// </summary>
		/// <param name="cid">Cakebox id number</param>
		/// <param name="filter">A prepared string to filter results ex: %criminal%</param>
		/// <param name="orderBy">0-2 for sorting fields id, label and filesno</param>
		/// <param name="orderWay">0: Ascending, 2: Descending</param>
		/// <returns>A list of matched discs</returns>
		public static List<Identity> FetchDiscsByCakeboxId(int cid, string filter = null, int orderBy = 1, int orderWay = 0)
		{
			List<Identity> list = new List<Identity>();
			try
			{
				string orderClause = null;
				switch(orderBy)
				{
						case 0: orderClause = "id"; 					break;
						case 1: orderClause = "label COLLATE NOCASE"; 	break;
						case 2: orderClause = "filesno";			 	break;
				}

				string sql = "SELECT id, label, filesno FROM disc WHERE cid = " + cid;
				sql += (filter != null) ? " AND ToLower(files) LIKE '" + filter + "'" : "";
				sql += " ORDER BY " + orderClause + " " + ((orderWay == 0) ? " ASC" : " DESC");
				
				SQLiteCommand c = CreateCommand(sql);
				SQLiteDataReader r = c.ExecuteReader();
				while (r.Read())
				{
					string label = r.GetString(1);
					int diskId = r.GetInt32(0);
					
					if(label.ToLower().Equals("movies") || orderBy == 0)
					{
						label = "#" + diskId + " - " + label;
					}
					if(orderBy == 2)
					{
						label += String.Format(" ({0:n0})", r.GetInt32(2));
					}
					list.Add(new Identity(diskId, label));
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
		
		/// <summary>
		/// Fetch disc label by id
		/// </summary>
		/// <param name="id">Disc id number</param>
		/// <returns>The disc label</returns>
		public static string FetchDiscLabelById(int id)
		{
			return ExecuteScalar("SELECT label FROM disc WHERE id = " + id);
		}
		
		/// <summary>
		/// Fetch files list, files number and added date by disc id
		/// </summary>
		/// <param name="id">Disc id number</param>
		/// <returns>File list, total files and added date</returns>
		public static object[] FetchFilesListByDiscId(int id)
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
		
		/// <summary>
		/// Insert/Update cakebox information. Include id for update, skip to insert a new one.
		/// </summary>
		/// <param name="label">Cakebox label</param>
		/// <param name="id">Cakebox id number (Optional)</param>
		public static void SaveCakebox(string label, int id = 0)
		{
			Dictionary<string, object> data = new Dictionary<string, object>();
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
		
		/// <summary>
		/// Delete cakebox by id
		/// </summary>
		/// <param name="id">Cakebox id number</param>
		public static void DeleteCakebox(int id)
		{
			if(id > 0)
			{
				ExecuteNonQuery("Delete FROM cakebox WHERE id = " + id);
			}
		}
		
		/// <summary>
		/// Update disc information
		/// </summary>
		/// <param name="id">Disc id number</param>
		/// <param name="cid">Disc's cakebox id number</param></param>
		/// <param name="label">Disc label</param>
		public static void UpdateDisc(int id, int cid, string label)
		{
			Dictionary<string, object> data = new Dictionary<string, object>();
			data.Add("cid", cid.ToString());
			data.Add("label", label);
			Update("disc", data, "id = " + id);
		}
		
		/// <summary>
		/// Add a new disc
		/// </summary>
		/// <param name="label">Disc label</param>
		/// <param name="files">Disc file list</param>
		/// <param name="filesno">File list length</param>
		/// <param name="cid">Disc's cakebox id number</param>
		/// <param name="added">Current Unixtimestamp</param>
		public static void AddDisc(string label, string files, int filesno, int cid, int added)
		{
			Dictionary<string, object> data = new Dictionary<string, object>();
			data.Add("cid", cid);
			data.Add("label", label);
			data.Add("files", files);
			data.Add("filesno", filesno);
			data.Add("added", added);
			Insert("disc", data);
		}
		
		/// <summary>
		/// Delete disc by id
		/// </summary>
		/// <param name="id">Disc id number</param>
		public static void DeleteDisc(int id)
		{
			if(id > 0)
			{
				ExecuteNonQuery("Delete FROM disc WHERE id = " + id);
			}
		}
		
		/// <summary>
		/// Move discs to a new cakeboxe
		/// </summary>
		/// <param name="target">Cakebox id number</param>
		/// <param name="discs">List of disc id numbers</param>
		public static void MoveDiscs(int target, List<int> discs)
		{
			Dictionary<string, object> data = new Dictionary<string, object>();
			data.Add("cid", target.ToString());
			Update("disc", data, "id IN (" + String.Join(", ", discs) + ")");
		}

		/// <summary>
		/// Fetch total cakeboxes
		/// </summary>
		public static int GetTotalCakeboxes()
		{
			return Convert.ToInt32(ExecuteScalar("SELECT COUNT(*) AS total FROM cakebox"));
		}
		
		/// <summary>
		/// Fetch total discs
		/// </summary>
		public static int GetTotalDiscs()
		{
			return Convert.ToInt32(ExecuteScalar("SELECT COUNT(*) AS total FROM disc"));
		}
		
		/// <summary>
		/// Fetch total files
		/// </summary>
		public static int GetTotalFiles()
		{
			return Convert.ToInt32(ExecuteScalar("SELECT COALESCE(SUM(filesno), 0) AS total FROM disc"));
		}
		
		/// <summary>
		/// Execute a query and retun a datatable with all results
		/// </summary>
		/// <param name="sql">The query string to execute</param>
		/// <returns></returns>
		public static DataTable Fetch(string sql)
		{
			DataTable data = new DataTable();
			try
			{
				SQLiteCommand c = CreateCommand(sql);
				SQLiteDataReader r = c.ExecuteReader();
				data.Load(r);
				r.Close();
				c.Dispose();
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
			}
			return data;
		}
		
		/// <summary>
		/// Update db table
		/// </summary>
		/// <param name="table">Table name</param>
		/// <param name="data">A list of keys and values representing db data</param>
		/// <param name="where">Where clause to update records</param>
		public static void Update(string table, Dictionary<string, object> data, string where)
		{
			try
			{
				List<string> sets = new List<string>();
				SQLiteCommand c = db.CreateCommand();
				foreach (KeyValuePair<string, object> pair in data)
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
		
		/// <summary>
		/// Insert single row of data in db table
		/// </summary>
		/// <param name="table">Table name</param>
		/// <param name="data">A list of keys and values representing db data</param>
		public static void Insert(string table, Dictionary<string, object> data)
		{
			if(data.Count > 0)
			{
				List<string> columns = new List<string>(data.Keys);
				List<object> values = new List<object>(data.Values);
				SQLiteCommand c = CreateCommand(String.Format("INSERT INTO {0} ({1}) VALUES (@{2})", table, String.Join(", ", columns), String.Join(", @", columns)));
				for(int i = 0; i < columns.Count; i++)
				{
					c.Parameters.Add(new SQLiteParameter("@"+columns[i], values[i]));
				}
				c.ExecuteNonQuery();
				c.Dispose();
			}
		}

		/// <summary>
		/// Execute non query
		/// </summary>
		/// <param name="sql">The query string to execute</param>
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
		
		/// <summary>
		/// Execute scalar
		/// </summary>
		/// <param name="sql">The query string to execute</param>
		/// <returns>The first column of the first row of the matched record</returns>
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
		
		/// <summary>
		/// Create sqlite command
		/// </summary>
		/// <param name="sql">The query string to prepare</param>
		/// <returns>The command ready to be executed</returns>
		public static SQLiteCommand CreateCommand(string sql)
		{
			SQLiteCommand c = db.CreateCommand();
			c.CommandText = sql;
			return c;
		}
	}
}