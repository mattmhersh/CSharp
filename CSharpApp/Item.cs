using System;
using CSharpLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp
{
	public class Item
	{
		private int _value;

		public Item(int i)
		{
			_value = i;
		}

		public int ID
		{
			get {
				return _value;
			}
		}
	}
}
