using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
	public interface IBroker
	{
		bool Buy(Stock stock);
		bool Sell(Stock stock);
		bool Cancel(Stock stock);
	}
}
