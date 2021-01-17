using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Order
{
    public class Pizzas
    {
        private string _kind;
        private decimal _price;

        public string Kind
        {
            get { return _kind; }
            set { _kind = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public override string ToString()
        {
            return "Kind :" + Kind + "," + "Price : " + Price;
        }

    }
}
