using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAdoNet
{
	/// <summary>
	/// This is my main Strategy abstract class for use with Context class
	/// </summary>
	public abstract class GenStrategy
	{
		/// <summary>
		/// Publicly available method that concrete implementation will depend on ConcreteClasses
		/// </summary>
		public abstract void TakeAction();
	}
}
