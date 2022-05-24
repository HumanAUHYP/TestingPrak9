using Microsoft.VisualStudio.TestTools.UnitTesting;
using CringePrak9;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CringePrak9Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetMedicinesInAptekaTest()
        {
            var medicines = new List<Medicine>();

            var apteka = new Apteka("Бари Галеева 3");

            var names = new List<string>{ "Дротаверин", "Платифиллин", "Ондансетрон" };
            var producers = new List<string> { "Тева", "Биокад", "Генериум" };

            for (int i = 0; i < 3; i++)
            {
                Medicine medicine = new Medicine(names[i], producers[i], 115 * (i + 1));

                apteka.AddMedicine(medicine, 10 * (i + 1));
                medicines.Add(medicine);
            }

            CollectionAssert.AreEqual(medicines, apteka.GetMedicinesInApteka());
        }

        [TestMethod]
        public void GetMedicinesByNameTest()
        {
            var medicines = new List<Medicine>();

            var apteka = new Apteka("Бари Галеева 3");

            var names = new List<string> { "Дротаверин", "Платифиллин", "Ондансетрон" };
            var producers = new List<string> { "Тева", "Биокад", "Генериум" };

            for (int i = 0; i < 3; i++)
            {
                Medicine medicine = new Medicine(names[i], producers[i], 115 * (i + 1));

                apteka.AddMedicine(medicine, 10 * (i + 1));
                if (i == 0) medicines.Add(medicine);
            }

            CollectionAssert.AreEqual(medicines, apteka.GetMedicinesByName("Дротаверин"));
        }

        [TestMethod]
        public void GetMedicinesByProducerTest()
        {
            var medicines = new List<Medicine>();

            var apteka = new Apteka("Бари Галеева 3");

            var names = new List<string> { "Дротаверин", "Платифиллин", "Ондансетрон" };
            var producers = new List<string> { "Тева", "Биокад", "Генериум" };

            for (int i = 0; i < 3; i++)
            {
                Medicine medicine = new Medicine(names[i], producers[i], 115 * (i + 1));

                apteka.AddMedicine(medicine, 10 * (i + 1));
                if (i == 1) medicines.Add(medicine);
            }

            CollectionAssert.AreEqual(medicines, apteka.GetMedicinesByProducer("Биокад"));
        }

        [TestMethod]
        public void GetSortedMedicines()
        {
            var medicines = new List<Medicine>();

            var apteka = new Apteka("Бари Галеева 3");

            var names = new List<string> { "Дротаверин", "Платифиллин", "Ондансетрон" };
            var producers = new List<string> { "Тева", "Биокад", "Генериум" };

            for (int i = 0; i < 3; i++)
            {
                Medicine medicine = new Medicine(names[i], producers[i], 115 * (i + 1));

                apteka.AddMedicine(medicine, 10 * (i + 1));
                medicines.Add(medicine);
            }
            medicines.OrderBy(m => m.Price).ToList();
            CollectionAssert.AreEqual(medicines, apteka.GetSortedMedicinesMinMax());
            medicines.Reverse();
            CollectionAssert.AreEqual(medicines, apteka.GetSortedMedicinesMaxMin());
        }

        [TestMethod]
        public void GetMostExpensiveTest()
        {
            var apteka = new Apteka("Бари Галеева 3");

            var names = new List<string> { "Дротаверин", "Платифиллин", "Ондансетрон" };
            var producers = new List<string> { "Тева", "Биокад", "Генериум" };
            Medicine waitingMedicine = null;

            for (int i = 0; i < 3; i++)
            {
                Medicine medicine = new Medicine(names[i], producers[i], 115 * (i + 1));

                apteka.AddMedicine(medicine, 10 * (i + 1));
                if (i == 2) 
                   waitingMedicine = medicine;
            }

            Assert.AreEqual(waitingMedicine, apteka.GetMostExponsiveMedicine());
        }
    }
}
