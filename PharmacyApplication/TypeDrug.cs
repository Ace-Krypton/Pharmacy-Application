using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApplication
{
    class TypeDrug
    {
        //Properties
        public string Name { get; set; }

        //Fields
        private static int _id; //For unique ID
        public readonly int ID; //For unique ID

        //Constructor for unique ID
        public TypeDrug()
        {
            _id++;
            ID = _id;
        }

        //Constructor for Name
        public TypeDrug(string name) : this()
        {
            Name = name;
        }

        //ToString() method that returns TypeName and
        public override string ToString()
        {
            return $"TypeName:{Name}";
        }

    }
}
