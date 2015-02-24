using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAdoNet
{
	/// <summary>
	/// A class representing a Person blueprint with name, age and money currntly in posession
	/// </summary>
	class Person
	{
		/// <summary>
		/// Read-only members for Name and Age of the personv
		/// </summary>
		private readonly string _name;
		private readonly int _age;

		/// <summary>
		/// Read-only property for the Name of the person
		/// </summary>
		public string Name
		{
			get {return _name;}
		}

		/// <summary>
		/// Read-only property for the Age of the person
		/// </summary>
		public int Age
		{
			get { return _age; }
		}

		/// <summary>
		/// Available Cash in the wallet for this person, it can very during
		/// the lifetime of the object of this type
		/// </summary>
		public int Cash
		{
			get;
			private set;
		}

		/// <summary>
		/// Custom constructor for person class
		/// </summary>
		/// <param name="name">Name of a person  - string</param>
		/// <param name="age">Age of a person - int</param>
		/// <param name="cash">Initial cash available for the person - int</param>
		public Person(string name, int age, int cash)
		{
			this._name = name;
			this._age = age;
			Cash = cash;
		}

		public override string ToString()
		{
			return String.Format("{0} is {1} years old and has {2} money available", Name, Age, Cash);
		}

		/// <summary>
		/// Give cash from my wallet
		/// </summary>
		/// <param name="amount">The amount of cash to give</param>
		/// <returns>The amount of cash I gave, or 0 if I don't have enough cash</returns>
		public int GiveCash(int amount)
		{
			if (amount <= Cash && amount > 0)
			{
				Cash -= amount;
				return amount;
			}
			else
			{
				return 0;
			}
		}

		/// <summary>
		/// Receive some cash into my wallet
		/// </summary>
		/// <param name="amount">Amount to receive</param>
		/// <returns>The amount of cash received, or 0 if no cash was received</returns>
		public int ReceiveCash(int amount)
		{
			if (amount > 0)
			{
				Cash += amount;
				return amount;
			}
			Console.WriteLine("{0} says: {1} is't an amount I will take", Name, amount);
			return 0;
		}
	}
}
