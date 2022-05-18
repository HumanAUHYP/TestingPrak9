using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TestingPrak9;

namespace Prak9Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetDrugsInPharamacyTest()
        {
            var drug1 = new Drug { Name = "Лаверон", Price = 574, Producer = "Тева" };
            var drug2 = new Drug { Name = "Bayan", Price = 210, Producer = "Pharm" };
            var drug3 = new Drug { Name = "Динамико", Price = 585, Producer = "Тева" };

            var Drugs = new List<Drug> { drug1, drug2, drug3 };



            var pharmacy = new Pharmacy("Бари Галеева 3")
            {
                Drugs = new Dictionary<Drug, int>()
                {
                    {drug1, 10 },
                    {drug2, 10 },
                    {drug3, 10 },
                }
            };

            CollectionAssert.AreEqual(Drugs, pharmacy.GetDrugsInPaharmacy());
        }

        [TestMethod]
        public void GetDrugsByNameTest()
        {
            var drug1 = new Drug { Name = "Лаверон", Price = 574, Producer = "Тева" };
            var drug2 = new Drug { Name = "Bayan", Price = 210, Producer = "Pharm" };
            var drug3 = new Drug { Name = "Динамико", Price = 585, Producer = "Тева" };

            var Drugs = new List<Drug> { drug1 };



            var pharmacy = new Pharmacy("Бари Галеева 3")
            {
                Drugs = new Dictionary<Drug, int>()
                {
                    {drug1, 10 },
                    {drug2, 10 },
                    {drug3, 10 },
                }
            };

            CollectionAssert.AreEqual(Drugs, pharmacy.GetDrugsByName("Лаверон"));
        }

        [TestMethod]
        public void GetDrugsByProducerTest()
        {
            var drug1 = new Drug { Name = "Лаверон", Price = 574, Producer = "Тева" };
            var drug2 = new Drug { Name = "Bayan", Price = 210, Producer = "Pharm" };
            var drug3 = new Drug { Name = "Динамико", Price = 585, Producer = "Тева" };

            var Drugs = new List<Drug> { drug1, drug3 };



            var pharmacy = new Pharmacy("Бари Галеева 3")
            {
                Drugs = new Dictionary<Drug, int>()
                {
                    {drug1, 10 },
                    {drug2, 10 },
                    {drug3, 10 },
                }
            };

            CollectionAssert.AreEqual(Drugs, pharmacy.GetDrugsByProducer("Тева"));
        }

        [TestMethod]
        public void GetSortedDrugs()
        {
            var drug1 = new Drug { Name = "Лаверон", Price = 574, Producer = "Тева" };
            var drug2 = new Drug { Name = "Bayan", Price = 210, Producer = "Pharm" };
            var drug3 = new Drug { Name = "Динамико", Price = 585, Producer = "Тева" };

            var Drugs = new List<Drug> { drug1, drug2, drug3 };

            Drugs = Drugs.OrderByDescending(x => x.Price).ToList();

            var pharmacy = new Pharmacy("Бари Галеева 3")
            {
                Drugs = new Dictionary<Drug, int>()
                {
                    {drug1, 10 },
                    {drug2, 10 },
                    {drug3, 10 },
                }
            };

            CollectionAssert.AreEqual(Drugs, pharmacy.GetSortedDrugs(true));
            Drugs.Reverse();
            CollectionAssert.AreEqual(Drugs, pharmacy.GetSortedDrugs());
        }

        [TestMethod]
        public void GetMostExpensiveTest()
        {
            var drug1 = new Drug { Name = "Лаверон", Price = 574, Producer = "Тева" };
            var drug2 = new Drug { Name = "Bayan", Price = 210, Producer = "Pharm" };
            var drug3 = new Drug { Name = "Динамико", Price = 585, Producer = "Тева" };

            var Drug = drug3;



            var pharmacy = new Pharmacy("Бари Галеева 3")
            {
                Drugs = new Dictionary<Drug, int>()
                {
                    {drug1, 10 },
                    {drug2, 10 },
                    {drug3, 10 },
                }
            };

            Assert.AreEqual(Drug, pharmacy.GetMostExponsiveDrug());
        }
    }
}
