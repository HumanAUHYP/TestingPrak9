using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPrak9
{
    public class Pharmacy
    {
        public string Address { get; set; }

        public Dictionary<Drug, int> Drugs { get; set; }

        public Pharmacy()
        {
            Drugs = new Dictionary<Drug, int>();
        }

        public Pharmacy(string address) : base()
        {
            Address = address;
        }

        public void AddDrug(Drug drug, int count)
        {
            Drugs.Add(drug, count);
        }

        public List<Drug> GetDrugsByName(string name)
        {
            return Drugs.Keys.Cast<Drug>().Where(x => x.Name == name).ToList();
        }

        public List<Drug> GetDrugsByProducer(string producer)
        {
            return Drugs.Keys.Cast<Drug>().Where(x => x.Producer == producer).ToList();
        }

        public Drug GetMostExponsiveDrug()
        {
            return Drugs.Keys.Where(x => x.Price == Drugs.Keys.Max(y => y.Price)).FirstOrDefault();
        }

        public List<Drug> GetSortedDrugs(bool desc = false)
        {
            var drugs = Drugs.Keys.OrderBy(x => x.Price).ToList();

            if (desc)
                drugs.Reverse();

            return drugs;
        }

        public List<Drug> GetDrugsInPaharmacy()
        {
            return Drugs.Keys.ToList();
        }
    }
}
