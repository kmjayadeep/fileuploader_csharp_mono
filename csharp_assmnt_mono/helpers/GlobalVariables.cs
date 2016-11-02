using System;
using csharp_assmnt_mono.models;

namespace csharp_assmnt_mono.helpers
{ 
	public class GlobalVariables
	{
		public static User loggedInUser = null;
		public static string connectionString =  "Data Source=SqliteTest.db,version=3";
	}
}

