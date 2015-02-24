using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAdoNet
{
	/// <summary>
	/// Main starting point of my Applicaton
	/// </summary>
	class MyApp
	{
		static void Main(string[] args)
		{
			Console.WriteLine("=== Starting Point ===");
			Switcher sw;
			sw = new Switcher(new IsolatedStorage());
			sw.GoToCorrectAction();

			Console.WriteLine("=== End Point ===");
			Console.ReadLine();
		}
	}
}
