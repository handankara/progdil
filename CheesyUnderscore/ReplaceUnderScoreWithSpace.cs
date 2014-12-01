using System;
using System.Collections.Generic;

namespace ReplaceUnderScoreWithSpace
{
	static class CheesyUnderscore
	{
		public static void Main (string[] args)
		{
			foreach (string arg in args) {
				Console.WriteLine (arg.ReplaceUnderScoreWithSpace ()); //extension method
			}
		}

		public static char[] ReplaceUnderScoreWithSpace (this string arg)
		{
			char[] chars = arg.ToCharArray ();
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
			return chars;
		}
	}
}
