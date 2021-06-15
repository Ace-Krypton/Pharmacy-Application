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
            TypeDrug type2 = new TypeDrug("Heart Rate Stabilazer");

            Drug drug1 = new Drug("Analgin", 0.80, 12, type1);
            Drug drug2 = new Drug("Valerian", 1.20, 50, type2);

            Pharmacy zeferan = new Pharmacy("Zeferan");
            zeferan.AddDrug(drug1);
            zeferan.AddDrug(drug2);
            zeferan.DrugList();

        }
    }
}
