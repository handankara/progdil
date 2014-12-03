using System;

namespace ProjectNames
{
	public class ProjectNamesMain
	{
		public static void Main (string[] args)
		{
			try {
				// string language = args [0];
				// int againcount = Convert.ToInt32 (args [1]);
				// RollingNames projectnames = new RollingNames (language, againcount);
				RollingNames projectnames = new RollingNames ();
				projectnames.ProjectNamerator ();
				foreach (string projectname in projectnames.produced)
					Console.WriteLine (projectname);
			} catch {
				help ();
			}
		}

		public static void help ()
		{
			Console.Write ("Kullanım :\n" +
				"mono program.exe tr i------> i tane Türkçe üretir\n" +
				"mono program.exe en i -----> i tane İngilizce üretir\n");
		}
	}
}