using System;
using System.Diagnostics;

namespace CSharpLibrary
{
	public class BetterDebugWindowLogger
	{
		public void SendMessage(string message) {
			Debug.WriteLine (message + " better!");
		}
	}
}

