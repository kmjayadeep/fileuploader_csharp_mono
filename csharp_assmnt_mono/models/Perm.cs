using System;
using System.Data;

namespace csharp_assmnt_mono.models
{
	public class Perm
	{
		public int fileid { get; set; }
		public int ownerid { get; set; }
		public Perm(int fileid, int ownerid)
		{
			this.fileid = fileid;
			this.ownerid = ownerid;
		}
		public Perm(DataRow row)
		{
			this.fileid = (int)row["fileid"];
			this.ownerid = (int)row["ownerid"];
		}
	}
}

