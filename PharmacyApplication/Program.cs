using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeDrug type1 = new TypeDrug("HeadAche");

            Drug drug1 = new Drug("Analgin", 0.80, 12, type1);
            Console.WriteLine(drug1);

            Pharmacy pharmacy1 = new Pharmacy("Zeferan");


        }
    }
}
