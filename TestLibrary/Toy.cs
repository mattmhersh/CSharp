using System;

namespace CSharpLibrary
{
	public class Toy
	{

		public string Name { get; set; }
		public string Color { get; set; }
		public virtual void Purchase()
		{
			Console.WriteLine ("Purchasing {0}", Name);
		}
	}
}

