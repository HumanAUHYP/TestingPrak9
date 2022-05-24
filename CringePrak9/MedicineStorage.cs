using System;
namespace CringePrak9
{
    public class MedicineStorage
    {
        public Medicine Medicine { get; set; }
        public int Count { get; set; }

        public MedicineStorage(Medicine medicine, int count)
        {
            Medicine = medicine;
            Count = count;
        }
    }
}
