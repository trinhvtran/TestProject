using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
	class Program
	{
		static void Main(string[] args)
		{
			TestBroker broker = new TestBroker();
			Stock s = new Stock(broker);
			s.Symbol = "AAPL";
			s.Price = 100.00m;
			s.Order();

			Console.ReadLine();
		}
	}
}
