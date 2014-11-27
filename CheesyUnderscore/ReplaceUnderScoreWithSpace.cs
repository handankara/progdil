using System;
using System.Collections.Generic;

namespace ReplaceUnderScoreWithSpace
{
	static class MainClass
	{
		private static char[] chars;

		public static void Main (string[] args)
		{
			foreach (string arg in args) {
				arg.ReplaceUnderScoreWithSpace (); //extension method
			}
			Console.WriteLine (chars);
		}

		public static void ReplaceUnderScoreWithSpace (this string arg)
		{
			chars = arg.ToCharArray ();
			int i = 0;
			int j = (chars.Length) - 1;
		
			while (i < chars.Length) {
				if (chars [i].ToString () != "_")
					break;
				i++;
			}
			while (j >= 0) {
				if (chars [j].ToString () != "_")
					break;
				j--;
			}
			for (int c = i; c < j; c++) {
				chars [c] = (chars [c] == '_') ? ' ' : chars [c];
			}
		}
	}
}
