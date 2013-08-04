using System;
using NUnit.Framework;
using CSharpLibrary;
using System.Diagnostics;

namespace CSharp
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void When_getting_a_person_name_return_a_name ()
		{
			// Arrange
			//var person = new Person ();

			// Act
			var name = Person.Name ();

			// Assert
			Assert.That(name, Is.EqualTo("Matt Hersh"));
		}

		[Test]
		public void When_getting_a_person_return_an_address()
		{
			// Arrange

			// Act
			var address = Person.Address ();

			// Assert
			Assert.That (address, Is.Not.Null);
		}

		[Test]
		public void When_getting_a_car()
		{
			// Arrange
			var car = new Car ();

			// Act
			car.Name = "Porsche";
			car.Color = "Red";
			car.Wheels = "HRE";

			// Assert
			Assert.That (car.Name, Is.Not.Null);
		}

		[Test]
		public void When_checking_the_car_age()
		{
			// Arrange
			var car = new Car ();

			// Act
			car.SetAge (12);
			int age = car.MyAge();

			Assert.That (age, Is.EqualTo(14));
		}

		[Test]
		public void When_testing_an_Employee()
		{
			// Arrange
			var employee = new Employee () {
				Age = 21,
				Name = "Matt H",
				Salary = 100000,
				PhoneNumber = "8885551234",
				StartingDate = DateTime.Now.AddYears(-5)
			};

			Debug.WriteLine(employee.StartingDate.ToShortDateString());

			// Assert
			Assert.That (employee.Name, Is.Not.Null);

		}
	}
}

