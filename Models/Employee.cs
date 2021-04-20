using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFootRestorant
{
    public class Employee
    {
        private int Id{ get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
    }
}
