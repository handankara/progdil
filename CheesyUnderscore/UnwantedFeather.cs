using System;
using System.Collections.Generic;

namespace CheesyUnderscore
{
	static class CheesyUnderscore //extension method kullanabilmek için static yap
	{
		public static void Main (string[] args)
		{
			foreach (string arg in args)
				Console.WriteLine (arg.ReplaceUnderScoreWithSpace ());
		}

		public static char[] ReplaceUnderScoreWithSpace (this string arg) //this ve extension method
		{
			char[] chars = arg.ToCharArray ();
			int index = indexcontrol (chars);
			Array.Reverse (chars);
			int indexlast = indexcontrol (chars);
			Array.Reverse (chars);
			for (int i = index; i < (chars.Length - indexlast); i++) 
				chars [i] = (chars [i] == '_') ? ' ' : chars [i]; //Tek tırnak char - Çift tırnak string
			return chars;
		}

		public static int indexcontrol (char[] chars)
		{	
			int index = 0;
			while (index < chars.Length) {
				if (chars [index] != '_')
					break;
				index++;
			}
			return index;
		}
	}
}
