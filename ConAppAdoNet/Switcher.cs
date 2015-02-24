using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAdoNet
{
	/// <summary>
	/// This is a Context switching class, bases on the type of passing strategy we wil
	/// take appropriate action
	/// </summary>
	class Switcher
	{
		GenStrategy _switcher;

		public Switcher(GenStrategy strategy)
		{
			_switcher = strategy;
		}

		public void GoToCorrectAction()
		{
			_switcher.TakeAction();
		}
	}
}
