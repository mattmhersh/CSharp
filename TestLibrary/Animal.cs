using System;

namespace CSharpLibrary
{
	public abstract class Animal
	{
		public abstract void PerformTrick();
		public virtual void Bark () {
			Console.WriteLine ("bark");
		}
	}
}

