using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo
{
    public class Model
    {
        public List  <StockMarket> stockMarket;

    }
    public class StockMarket
    {
        public string shareName { get; set; }
        public int numberOfShare { get; set; }
        public int sharePrice { get; set; }
    }

}
