using System;

namespace CSharpLibrary
{
	public class Dog : Animal
	{

		public override void PerformTrick ()
		{
			// roll over
			Console.WriteLine ("Roll Over");

			base.Bark ();
		}

	}
}

