using System;
using NUnit.Framework;
using CSharpLibrary;

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

			Assert.That (age, Is.EqualTo(12));
		}
	}
}

