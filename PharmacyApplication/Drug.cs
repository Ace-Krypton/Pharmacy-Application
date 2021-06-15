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
        public double Price { get; set; }
        public int Count { get; set; }
        public TypeDrug TypeName { get; set; }

        //Fields
        private static int _id; //For unique ID
        public readonly int ID; //For unique ID

        //Constructor for unique ID
        public Drug()
        {
            _id++;
            ID = _id;
        }
        //Constructor for Price Count Name and TypeName
        public Drug(string name, double price, int count, TypeDrug type) : this()
        {
            Name = name;
            Price = price;
            Count = count;
            TypeName = type;
        }

        //ToString() method that returns ID, Name, Price and Count  
        public override string ToString()
        {
            return $"ID:{ID} Name:{Name} Price:{Price} Count:{Count}";
        }

    }
}
