using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
	public class Stock : IStock
	{
		public decimal Price { get; set; }
		public string Symbol { get; set; }
		private IBroker _broker;

		public Stock(IBroker broker)
		{
			_broker = broker;
		}

		public bool Order()
		{
			return _broker.Buy(this);
		}
	}
}
