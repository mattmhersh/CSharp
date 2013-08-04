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
			age = UpdateAge(someAge);
		}

		private int UpdateAge(int someAge)
		{
			return someAge + 2;
		}

		public override void Purchase ()
		{
			base.Purchase ();
			Console.WriteLine ("I have been Purchased");
		}
	}
}

