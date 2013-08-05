using System;

namespace CSharpLibrary
{
	public class Manager : Employee
	{
		public override void GiveRaise ()
		{
			Salary += Salary * 0.05;
		}
	}
}

