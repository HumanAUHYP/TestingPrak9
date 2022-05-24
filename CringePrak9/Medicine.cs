using System;
namespace CringePrak9
{
    public class Medicine
    {
        public string Name { get; set; }
        public string Producer { get; set; }
        public double Price { get; set; }

        public Medicine(string name, string producer, double price)
        {
            Name = name;
            Producer = producer;
            Price = price;
        }
    }
}
