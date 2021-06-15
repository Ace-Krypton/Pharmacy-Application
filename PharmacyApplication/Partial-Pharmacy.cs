using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApplication
{
    partial class Pharmacy
    {
        //ToString() method that returns Name
        public override string ToString()
        {
            return $"Name:{Name}";
        }

        //AddDrug method that helps to add new drugs into drugs method in Pharmacy class
        public void AddDrug(Drug newDrug)
        {
            Array.Resize(ref drugs, drugs.Length + 1);
            drugs[drugs.Length - 1] = newDrug;
            Console.WriteLine($"{newDrug} -- added");
        }

        //DrugList method for seeing all drugs in the pharmacy
        public void DrugList()
        {
            Console.WriteLine($"Drugs in this Pharmacy {Name}:");

            foreach (Drug item in drugs)
            {
                Console.WriteLine(item);
            }
        }

    }
}
