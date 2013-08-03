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
	}
}

