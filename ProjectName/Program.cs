using System;
using System.Collections.Generic;

namespace ProjectName
{
	public class MainClass
	{
		public static void Main (string[] args)
		{
			int tekrar = 1;
			string language = "tr";
			if (args.Length == 2) 
			{
				if (args [0] == "en" & int.TryParse (args [1], out tekrar))
					language = args [0];
				else
					help ();
			} 
			else if (args.Length == 1) 
			{
				if (args [0] == "en")
					language = args [0];
				else if (int.TryParse (args [0], out tekrar)) 
				{
				}
				else
					help ();
			} 
			else if (args.Length == 0)
			{
			}
			else
				help();
			RollingName isim = new RollingName(language, tekrar) ;
		}
		public static void help()
		{
			Console.Write("Kullanım :\n" +
				"mono program.exe ------> 1 tane Türkçe üretir\n" +
				"mono program.exe 5 ----> 5 tane Türkçe üretir\n" +
				"mono program.exe en ---> 1 tane İngilizce üretir\n" +
				"mono program.exe en 5 -> 5 tane İngilizce üretir\n");
		}
	}

}