using System;
using csharp_assmnt_mono.models;

namespace csharp_assmnt_mono.helpers
{ 
	public class GlobalVariables
	{
		public static Owner loggedInUser = null;
		public static string starting = "login.aspx";
		public static string connectionString = "URI=file:SqliteTest.db";
	}
}

