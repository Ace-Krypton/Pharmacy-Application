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
            //Type of Drugs
            TypeDrug type1 = new TypeDrug("HeadAche"); //creating type1 of drugs
            TypeDrug type2 = new TypeDrug("Heart Rate Stabilazer"); //creating type2 of drugs

            //Name, Price, Count and types of drugs
            Drug drug1 = new Drug("Analgin", 0.80, 12, type1); //creating drug1 
            Drug drug2 = new Drug("Valerian", 1.20, 50, type2); //creating drug2

            //Getting instance from pharmacy class and creating object
            Pharmacy zeferan = new Pharmacy("Zeferan");
            zeferan.AddDrug(drug1); //Adding drug1 into our Array
            zeferan.AddDrug(drug2); //Adding drug2 into our Array
            Console.WriteLine("==================================");
            zeferan.DrugList(); //Lists all the drugs in our Array
            Console.WriteLine("==================================");
            zeferan.SaleDrug(5, 12, 1.2);

        }
    }
}
