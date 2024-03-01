using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer
    {
        //Fields
        public int Age;

        //Property
        public int Id { get; set; }
        private string _firstName { get; set; }
        public string FirstName { 
            get
            {
                return "Mr. " + _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
