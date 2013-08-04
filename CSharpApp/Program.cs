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
			Console.Write ("How old are you? ");
			int age = int.Parse (Console.ReadLine ());

			switch (age) {
				case 1:
				Console.WriteLine ("Happy First Birthday! ");
				break;
				case 2:
				Console.WriteLine ("Happy 2nd Birthday! ");
				break;
				default:
				Console.WriteLine("Happy {0} Birthday! ", age);
				break;
			}

			int do_age = age;
			int for_age = age;

			do { 
				Console.WriteLine ("Hello Do"); 
				do_age--;
			}
			while (do_age > 0);

			while (age > 0)
			{
				Console.WriteLine ("Happy Birthday ");
				age--;
			}

			for (int i = 0; i < for_age; i++)
			{
				Console.WriteLine ("For Loop Happy Birthday ");
			}

			Console.WriteLine ("\nTaDa");

			int k = 12;
			Console.WriteLine (k++);
			Console.WriteLine (k);
			Console.WriteLine (++k);

			Console.ReadLine ();
		}

		void Test()
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

			byte byt = 10;
			Console.WriteLine (byt);

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

			int number1 = 12;
			double number2 = 13.2;

			double sum = number1 + number2;

			int a = 2;
			int b = 3;
			int c = 5;

			bool result1 = a + b == c;
			Console.WriteLine(result1);

			Console.WriteLine (sum);
		}
	}
}
