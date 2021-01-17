using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Order
{
    public class Orders
    {
        private string _customer;
        private string _type;
        private int _amount;

        public string Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public override string ToString()
        {
            return "Customer Name :" + Customer + ", Pizzas Type:" + Type + ", Amount :" + Amount;
        }

    }
}
