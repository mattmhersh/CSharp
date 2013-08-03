using System;
using CSharpLibrary;

namespace CSharpApp
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (Person.Name());

			Stack s = new Stack(); 
			s.Push(1);
			s.Push(10);
			s.Push(100); 

			Console.WriteLine(s.Pop()); 
			Console.WriteLine(s.Pop()); 
			Console.WriteLine(s.Pop());		

			Console.ReadLine ();
		}
	}
}
