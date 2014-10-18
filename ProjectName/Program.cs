using System;

namespace ProjectName
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int tekrar = 1;
			if (args.Length == 2) 
			{
				if (args [0] == "en" & int.TryParse (args [1], out tekrar))
					Console.WriteLine ("ingilizce " + tekrar + " tane");
				else
					Console.WriteLine ("help();");
			} 
			else if (args.Length == 1) 
			{
				if (args [0] == "en")
					Console.WriteLine ("ingilizce " + tekrar + " tane");
				else if (int.TryParse (args [0], out tekrar))
					Console.WriteLine ("turkce " + tekrar + " tane");
				else
					Console.WriteLine ("help();");
			} 
			else if (args.Length == 0)
			{
				Console.WriteLine ("turkce " + tekrar + " tane");
			}
			else
				Console.WriteLine ("help();");
		}
	}
}
