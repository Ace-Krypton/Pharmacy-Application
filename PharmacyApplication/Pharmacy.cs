using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApplication
{
    class Pharmacy
    {
        //Properties
        public string Name { get; set; }

        //Fields
        private static int _id;
        public readonly int ID;

        //Constructor for unique ID
        public Pharmacy()
        {
            _id++;
            ID = _id;
        }

        //ToString() method that returns Name and ID
        public override string ToString()
        {
            return $"Name:{Name} ID:{ID}";
        }

    }
}
