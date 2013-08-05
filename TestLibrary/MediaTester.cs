using System;

namespace CSharpLibrary
{
	public class MediaTester
	{
		public delegate int TestMedia();

		public void RunTest(TestMedia testDelegate)
		{
			int result = testDelegate ();

			if (result == 0) {
				Console.WriteLine ("Works!");
			} 
			else {
					Console.WriteLine ("Failed.");
			}
		}
	}
}

