using System;

namespace CSharpLibrary
{
	public class Refrigerator : IAppliance
	{
		#region IAppliance implementation

		public void On ()
		{
			throw new NotImplementedException ();
		}

		public void Off ()
		{
			throw new NotImplementedException ();
		}

		public string Name ()
		{
			throw new NotImplementedException ();
		}


		#endregion
	}
}

