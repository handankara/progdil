using System;

namespace ProjectNames
{
	public class ProjectNamesMain
	{
		public static void Main (string[] args)
		{
			int againcount = 1;
			string language = "tr";
			if (args.Length == 2) {
				if (args [0] == "en" & int.TryParse (args [1], out againcount))
					language = args [0];
				else
					help ();
			} else if (args.Length == 1) {
				if (args [0] == "en")
					language = args [0];
				else if (int.TryParse (args [0], out againcount)) {
				} else if (args [0] == "help")
					help ();
				else
					help ();
			} else if (args.Length == 0) {
			} else
				help ();
			RollingNames projectnames = new RollingNames (language, againcount);
			foreach (string projectname in projectnames.produced)
				Console.WriteLine (projectname);
		}

		public static void help ()
		{
			Console.Write ("Kullanım :\n" +
				"mono program.exe ------> 1 tane Türkçe üretir\n" +
				"mono program.exe 5 ----> 5 tane Türkçe üretir\n" +
				"mono program.exe en ---> 1 tane İngilizce üretir\n" +
				"mono program.exe en 5 -> 5 tane İngilizce üretir\n");
		}
	}
}