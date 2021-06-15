using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApplication
{
    partial class Pharmacy
    {
        //Properties
        public string Name { get; set; }

        //Fields
        private static int _id;
        public readonly int ID;
        private Drug[] drugs = new Drug[0];

        //Constructor for unique ID
        public Pharmacy()
        {
            _id++;
            ID = _id;
        }

        //Constructor for Name
        public Pharmacy(string name) : this()
        {
            Name = name;
        }
    }
}
