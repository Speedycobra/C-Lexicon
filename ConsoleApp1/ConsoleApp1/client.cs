using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Client : Person
    {
        public Client(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            
        }
        public override string ToString()
        {
            return "I am a client: " + base.ToString();
        }
    }
}
