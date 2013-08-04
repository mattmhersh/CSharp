using System;

namespace CSharpLibrary
{
	public class Car : Toy
	{
		private int age;

		public string Wheels { get; set; }

		public int MyAge()
		{
			return age;
		}

		public void SetAge(int someAge)
		{
			age = someAge;
		}
	}
}

