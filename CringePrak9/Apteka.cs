using System;
using System.Collections.Generic;
using System.Linq;

namespace CringePrak9
{
    public class Apteka
    {
        public string Address { get; set; }

        public Dictionary<Medicine, int> Medicines { get; set; }

        public Apteka()
        {
            Medicines = new Dictionary<Medicine, int>();
        }

        public Apteka(string address)
        {
            Medicines = new Dictionary<Medicine, int>();
            Address = address;
        }

        public void AddMedicine(Medicine med, int count)
        {
            Medicines.Add(med, count);
        }

        public List<Medicine> GetMedicinesByName(string name)
        {
            var meds = Medicines.Keys.Where(x => x.Name == name).ToList();
            return meds;
        }

        public List<Medicine> GetMedicinesByProducer(string producer)
        {
            return Medicines.Keys.Where(x => x.Producer == producer).ToList();
        }

        public Medicine GetMostExponsiveMedicine()
        {
            return Medicines.Keys.OrderByDescending(x => x.Price).ToList()[0];
        }

        public List<Medicine> GetSortedMedicinesMinMax()
        {
            return Medicines.Keys.OrderBy(x => x.Price).ToList();
        }

        public List<Medicine> GetSortedMedicinesMaxMin()
        {
            return Medicines.Keys.OrderByDescending(x => x.Price).ToList();
        }

        public List<Medicine> GetMedicinesInApteka()
        {
            return Medicines.Keys.ToList();
        }
    }
}
