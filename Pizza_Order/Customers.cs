using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Order
{
    public class Customers
    {
        private string _name;
        private string _surname;
        private string _tel;
        private string _address;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public override string ToString()
        {
            return Name + "," + Surname + "," + Tel + "," + Address;
        }

    }
}
