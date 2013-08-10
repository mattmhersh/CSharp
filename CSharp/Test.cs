using System;
using NUnit.Framework;
using CSharpLibrary;
using System.Diagnostics;
using FakeItEasy;

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
			var employee = new Employer () {
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

		[Test]
		public void When_testing_fakes() {

			// Creating a fake object is just dead easy!
			// No mocks, no stubs, everything's a fake!
			var appliance = A.Fake<IAppliance>();


			// To set up a call to return a value is also simple:
			A.CallTo (() => appliance.On ()).MustNotHaveHappened ();

		}

		[Test]
		public void When_a_dog_barks() {
			// Arrange

			var dog = A.Fake<Animal> ();

			// Assert
			A.CallTo (() => dog.PerformTrick ()).CallsBaseMethod ();
		}

		[Test]
		public void When_a_real_dog_barks() {
			// Arrange
			var dog = new Dog ();


			// Act
			dog.PerformTrick ();

			// Assert

		}

		[Test]
		public void When_using_a_complex_object()
		{
			// Arrange
			var complex = new Complex ();
			complex.Imaginary = 9;
			complex.Real = 8;

			// Act
			complex.Real += 2;

			// Assert
			Assert.That(complex.Real, Is.EqualTo(10));

		}

		[Test]
		public void IdentityTest()
		{
			Invoice firstInvoice = new Invoice ();
			firstInvoice.ID = 1;
			firstInvoice.Description = "Test";
			firstInvoice.Amount = 0.0M;

			Invoice secondInvoice = new Invoice ();
			secondInvoice.ID = 1;
			secondInvoice.Description = "Test";
			secondInvoice.Amount = 0.0M;

			Assert.IsFalse (object.ReferenceEquals (secondInvoice, firstInvoice));
			Assert.IsTrue (firstInvoice.ID == 1);

			secondInvoice.ID = 2;

			Assert.IsTrue (secondInvoice.ID == 2);
			Assert.IsTrue (firstInvoice.ID == 1);

			secondInvoice = firstInvoice;

			Assert.IsTrue(object.ReferenceEquals(secondInvoice, firstInvoice));

			secondInvoice.ID = 5;
			Assert.IsTrue (firstInvoice.ID == 5);
		}
	}
}

