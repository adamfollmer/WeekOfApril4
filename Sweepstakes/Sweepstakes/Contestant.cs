using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        string name;
        string address;
        string phone;

        public Contestant (string name, string address, string phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
        public string Name
        {
            get { return name; }
        }
        public string Address
        {
            get { return address; }
        }
        public string Phone
        {
            get { return phone; }
        }
    }
}
