using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApplication
{
    class Drug
    {
        //Properties
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        //Fields
        private static int _id; //For unique ID
        public readonly int ID; //For unique ID
        public Type TypeName; 

        //Constructor for unique ID
        public Drug()
        {
            _id++;
            ID = _id;
        }

        //ToString() method that returns Name, Price, Count and ID
        public override string ToString()
        {
            return $"Name:{Name} Price:{Price} Count:{Count} ID:{ID}";
        }

    }
}
