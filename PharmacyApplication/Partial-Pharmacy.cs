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
                    if (drug.Count >= count)
                    {
                        double totalPrice = count * drug.Price;

                        if (totalPrice <= price)
                        {
                            Console.WriteLine($"You bought {count} {drug.Name} successfully. Your  current balance is {price - totalPrice}");
                            return;
                        }

                        else
                            Console.WriteLine($"Please pay another {totalPrice -price} manat");

                        return;
                    }
                    else
                        Console.WriteLine($"We do not have this much -- {count} in our storage, We only have {drug.Count}");
                    return;
                }
            }
            Console.WriteLine($"This {id} is not found in our system");
        }
    }
}