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

            foreach (Drug drug in drugs)
            {
                Console.WriteLine(drug);
            }
        }

        //SaleDrug method
        public void SaleDrug(int id, int count, double price)
        {
            foreach (Drug drug in drugs)
            {
                if (drug.ID == id)
                {
                    return;
                }
            }
            Console.WriteLine($"This {id} is not found in our system");
        }

    }
}
