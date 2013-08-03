using System;
using CSharpLibrary;
using System.Collections.Generic;

namespace CSharpApp
{

	enum Color {
		Red,
		Green,
		Blue
	}

	class MainClass
	{

		class MyList<T> : List<T> {

			public event EventHandler OnAdd;

			public void Add(T item) {
				if (null != OnAdd) {
					OnAdd(this, null);
				}
				base.Add(item);
			}
		}

		static void l_OnAdd(object sender, EventArgs e) {
			Console.WriteLine("Element added...");
		}

		public static void Main (string[] args)
		{

			// Events
			MyList<int> l = new MyList<int>();
			l.OnAdd += new EventHandler(l_OnAdd);
			l.Add(1);
			l.Add(2);

			// Enum
			Console.WriteLine (Color.Red);

			int k = 0;
			while (k < 3) {
				Console.WriteLine(k); 
				k++;
			}

			const float pi = 3.1415927f; 
			const int r = 25; 
			Console.WriteLine(pi * r * r);

			byte b = 10;
			Console.WriteLine (b);

			int i = 123;
			object o = i; // Boxing 
			int j = (int)o; // Unboxing

			Console.WriteLine(j);
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
