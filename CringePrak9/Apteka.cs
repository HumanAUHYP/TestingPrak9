using System;
using System.Collections.Generic;
using System.Linq;

namespace CringePrak9
{
    public class Apteka
    {
        public string Address { get; set; }

        public List<MedicineStorage> Medicines { get; set; }

        public Apteka()
        {
            Medicines = new List<MedicineStorage>();
        }

        public Apteka(string address)
        {
            Medicines = new List<MedicineStorage>();
            Address = address;
        }

        public void AddMedicine(Medicine medicine, int count)
        {
            Medicines.Add(new MedicineStorage(medicine, count));
        }

        public List<Medicine> GetMedicinesByName(string name)
        {
            var medicines = Medicines.Keys.Where(x => x.Name == name).ToList();
            return medicines;
        }

        public List<Medicine> GetMedicinesByProducer(string producer)
        {
            return Medicines.Keys.Where(x => x.Producer == producer).ToList();
        }

        public Medicine GetMostExponsiveMedicine()
        {
            return Medicines.Keys.Where(x => x.Price == Medicines.Keys.Max(y => y.Price)).FirstOrDefault();
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
