using System;

namespace CSharpLibrary
{
	public class Worker : Employee
	{
		public override void GiveRaise ()
		{
			Salary += Salary * 0.03;
		}
	}
}

