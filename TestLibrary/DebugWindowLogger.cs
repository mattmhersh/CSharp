using System;
using System.Diagnostics;

namespace CSharpLibrary
{
	public class DebugWindowLogger
	{
		public void SendMessage(string message) {
			Debug.WriteLine(message);
		}
	}
}

