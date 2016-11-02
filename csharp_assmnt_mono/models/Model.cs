using System;
using System.Data;
using csharp_assmnt_mono.helpers;

namespace csharp_assmnt_mono.models
{
	public class Model
	{
		public Model ()
		{
			
		}

		public static IDataReader executeSelectQuery(string sql){
			Database db = Database.Instance;
			IDbCommand dbcmd = db.getConnection().CreateCommand();
			dbcmd.CommandText = sql;
			IDataReader reader =  dbcmd.ExecuteReader();
			dbcmd.Dispose();
			return reader;
		}
	}
}

