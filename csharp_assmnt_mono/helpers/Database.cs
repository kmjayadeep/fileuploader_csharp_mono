using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using csharp_assmnt_mono.models;
using Mono.Data.Sqlite;

namespace csharp_assmnt_mono.helpers
{
	public sealed class Database
	{
		private IDbConnection dbcon;
		private static readonly Lazy<Database> lazy =
			new Lazy<Database>(() => new Database());

		public static Database Instance { get { return lazy.Value; } }

		private Database()
		{
			dbcon = new SqliteConnection (GlobalVariables.connectionString);
			dbcon.Open();
			executeMigration();
		}

		public IDbConnection getConnection(){
			return dbcon;
		}

		void executeMigration(){
			string sqlUser = "create table if not exists user(" +
			                 "id integer primary key autoincrement not null," +
			                 "name char(50)," +
			                 "email char(50) unique," +
			                 "password char(32)," +
			                 "level int not null default 0);";
			IDbCommand dbcmd = dbcon.CreateCommand();
			dbcmd.CommandText = sqlUser;
			dbcmd.ExecuteNonQuery();
			dbcmd.Dispose();
		}
	}
}

