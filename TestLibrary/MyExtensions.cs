using System;

namespace CSharpLibrary
{
	public static class MyExtensions
	{
		public static int WordCount(this String str)
		{
			return str.Split(new char[] { ' ', '.', '?' }, 
			StringSplitOptions.RemoveEmptyEntries).Length;
		}

		public static string FirstLetter(this String str)
		{
			return str.Substring (0, 1);
		}
	} 
}

