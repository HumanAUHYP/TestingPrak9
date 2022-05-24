using System;
namespace CringePrak9
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
