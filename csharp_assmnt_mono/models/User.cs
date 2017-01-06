using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace csharp_assmnt_mono.models
{
	public class User:Model
	{
		public int id { get; set; }
		public string name { get; set; }
		public string email { get; set; }
		public string password { get; set; }
		enum levels{
			NORMAL = 1,
			ADMIN = 2
		};
		int level { get; set; }
		public User(int id, string name, string email, string password, int level)
		{
			this.id = id;
			this.name = name;
			this.email = email;
			this.password = password;
			this.level = level;
		}
		public User(string name, string email, string password)
		{
			this.id = -1;
			this.name = name;
			this.email = email;
			this.password = password;
			this.level = 0;
		}
		public User(IDataReader reader)
		{
			id = reader.GetInt32 (0);
			name = reader.GetString (1);
			email = reader.GetString (2);
			password = reader.GetString (3);
			level = reader.GetInt32(4);
		}
		public static User login(string email,string password){
			string sql =
				"SELECT * " +
				"FROM user " +
				"WHERE email='"+email+"' and password='"+password+"'";
			Console.WriteLine (sql);
			IDataReader reader = executeSelectQuery (sql);
			User user = null;
			if(reader.Read())
			{
				user =  new User(reader);
			}
			reader.Dispose ();
			return user;
		}
		public static bool register(string name,string email,string password){
			string sql = "insert into user values(null,'" + name + "','" + email + "','" + password + "',"+(int)levels.NORMAL+")";
			int res = executeNonQuery(sql);
			Console.WriteLine (res);
			return res == 1;
		}
	}
}

