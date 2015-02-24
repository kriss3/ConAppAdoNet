using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAdoNet
{
	class IsolatedStorage: GenStrategy
	{
		public override void TakeAction()
		{
			Console.WriteLine("This is from {0}", this.GetType().Name);
		}
	}
}
