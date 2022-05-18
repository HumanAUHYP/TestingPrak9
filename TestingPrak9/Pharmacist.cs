using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPrak9
{
    public class Pharmacist
    {
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public double Exp { get; set; }

        public Pharmacist(string fullName, DateTime date, double exp)
        {
            FullName = fullName;
            Birthday = date;
            Exp = exp;
        }
    }
}
