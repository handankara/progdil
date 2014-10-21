using System;
using System.Collections.Generic;

namespace CheesyUnderscore
{
	static class MainClass
	{
		public static void Main (string[] args)
		{
			foreach (string arg in args) 
			{
				arg.ReplaceUnderScoreWithSpace();
			}
		}
		public static void ReplaceUnderScoreWithSpace(this string arg)
		{
				char[] chars = arg.ToCharArray ();
				int index = indexcontrol (chars);
				Array.Reverse (chars);
				int indexlast = indexcontrol (chars);
				Array.Reverse (chars);
				for (int i = index; i < (chars.Length - indexlast); i++) 
				{
					chars [i] = (chars [i].ToString() == "_") ? ' ' : chars [i];
				}
				Console.WriteLine (chars);
		}

		public static int indexcontrol(char[] chars)
		{	
			int i = 0;
			while (i < chars.Length) 
			{
				if (chars [i].ToString () != "_")
					break;
				i++;
			}
			return i;
		}
	}
}
