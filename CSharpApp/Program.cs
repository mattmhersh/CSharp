using System;
using CSharpLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp
{

	enum Color {
		Red,
		Green,
		Blue
	}

	class MainClass
	{

		public static void Main (string[] args)
		{
			//CollectionTest ();

			//AbstractClassExample ();

			//DelegateExample ();

			Console.ReadLine ();
		}

		public static void DelegateExample() {
			var tester = new MediaTester ();
			var mp3 = new MP3Player ();
			var mp4 = new MP4Player ();

			var mp3Delegate = new MediaTester.TestMedia (mp3.PlayMP3File);
			var mp4Delegate = new MediaTester.TestMedia (mp4.PlayMP4File);

			tester.RunTest (mp3Delegate);
			tester.RunTest (mp4Delegate);		
		}

		public static void AbstractClassExample()
		{
			var emp1 = new Worker ();
			emp1.Name = "David";
			emp1.Salary = 50000;

			var emp2 = new Manager();
			emp2.Name = "Rachel";
			emp2.Salary = 100000;

			var emp3 = new Manager ();
			emp3.Name = "Zach";
			emp3.Salary = 120000;

			var employees = new List<Employee> ();
			employees.Add(emp1);
			employees.Add(emp2);
			employees.Add(emp3);

			foreach (var emp in employees) {
				Console.Write ("{0}'s salary was {1}", emp.Name, emp.Salary);
				emp.GiveRaise ();
				Console.WriteLine (" but is now {0}", emp.Salary);
			}
		}

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

		private static void CollectionTest() {
			// Array
			var items = new Item[5];

			Random r = new Random ();
			for (int i = 0; i < items.Length; i++)
			{
				items [i] = new Item (r.Next (0, 10));
			}

			Console.WriteLine ("Items: ");
			foreach(Item itm in items) {
				Console.WriteLine ("Item: {0} ", itm.ID);
			}

			Item myItem = items [2];
			Console.WriteLine ("Item #2: {0}", myItem.ID);

			var authors = new Author[4];
			authors [0] = new Author () { Name = "Alie" };
			authors [1] = new Author () { Name = "Matt" };
			authors [2] = new Author () { Name = "John" };
			authors [3] = new Author () { Name = "Sam" };

			foreach(Author author in authors) {
				Console.WriteLine ("Author: {0}", author.Name);
			}

			String[] myArr = { "The", "QUICK", "BROWN", "FOX", "jumps", "over", "the", "lazy", "dog" };

			Array.Sort(myArr);

			foreach(string value in myArr) {
				Console.WriteLine("Value: {0}", value);
			}

			// List
			var myList = new List<Item>();
			myList.Add(new Item(10));
			myList.Add(new Item(20));
			myList.Add(new Item(30));
			foreach(var itm in myList) {
				Console.WriteLine("List Item: {0}", itm.ID);
			}

			Console.WriteLine("Queue");

			// Queue
			var myQueue = new Queue<int>();
			myQueue.Enqueue(10);
			int val = myQueue.Dequeue();
			Console.WriteLine("val: {0}", val);

			for(int i = 0; i < 50; i++) {
				myQueue.Enqueue(i);
			}

			foreach( int i in myQueue) {
				Console.WriteLine("{0}, ", i);
			}

			Console.WriteLine("Stack");

			// Stack
			var myStack = new Stack<int>();
			myStack.Push(10);
			int valb = myStack.Pop();
			Console.WriteLine("val: {0}", valb);

			for(int i = 0; i < 50; i++) {
				myStack.Push(i);
			}

			foreach( int i in myStack) {
				Console.WriteLine("{0}, ", i);
			}

			Console.WriteLine("Dictionary");

			// Dictionary
			Dictionary<string, string> capitals = new Dictionary<string, string>();
			capitals.Add("Alabama", "Montgomery");
			capitals.Add("Alaska", "Juneau");
			capitals.Add("Arizona", "Pheonix");
			capitals.Add("Massachusetts", "Boston");
			capitals.Add("Wyoming", "Cheyenne");

			foreach(var dic in capitals) {
				Console.WriteLine("State: {0} - Capital: {1}", dic.Key, dic.Value);
			}
		}

		void OOPTest()
		{
			var car = new Car ();
			car.Name = "Ferrari";
			car.Purchase ();
		}

		void ForTest()
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
