using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
	public class TestBroker : IBroker
	{
		public bool Buy(Stock stock)
		{
			Console.WriteLine("You just purchased {0} stock at {1} price.", stock.Symbol, stock.Price);

			return true;
		}

		public bool Cancel(Stock stock)
		{
			throw new NotImplementedException();
		}

		public bool Sell(Stock stock)
		{
			throw new NotImplementedException();
		}
	}
}
