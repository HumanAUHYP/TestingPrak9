using System;
namespace CringePrak9
{
    public class Aptekar
    {
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public double Exp { get; set; }

        public Aptekar(string fullName, DateTime date, double exp)
        {
            FullName = fullName;
            Birthday = date;
            Exp = exp;
        }
    }
}
