using System;
using System.Numerics;

namespace Weed {
    class Drug {
        public string Name { get; set; }
        public double MinCost { get; set; }
        public double MaxCost { get; set; }
        public double Cost { get; set; }
    }
    class Drugs {
        public int Length {get; set;}
        private Drug[] drugs;

        public Drugs(int length)
        {
            this.Length = length;
            this.drugs = new Drug[length];
        }

        public override string ToString()
        {
            string s = "";
            foreach (var item in drugs)
            {
                s +=  item.Name + " " + item.Cost + " \n";
            }

            return s;
        }

        public void Insert(Drug d)
        {
            this.drugs[this.Length] = d;
            this.Length++;
        }

        public Drug this[int index]
        {
            get {return this.drugs[index]; }
        }
    }
}