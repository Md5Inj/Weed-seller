using System;
using System.Collections;
using System.IO;
using System.Numerics;

namespace Weed {
    class Drug {
        public string Name { get; set; }
        public double MinCost { get; set; }
        public double MaxCost { get; set; }
        public double Cost { get; set; }

        public void Input()
        {
            Console.Write("Input name: "); this.Name = Console.ReadLine();
            Console.Write("Input minimum cost: "); this.MinCost = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input maximum cost: "); this.MaxCost = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input cost of drug: "); this.Cost = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return String.Format($"name of drug: {this.Name} \n cost of drug: {this.Cost} \n");
        }
    }
    class Drugs {
        private string fn = "drugs";
        private ArrayList drugs = new ArrayList();

        public Drugs()
        {
            if (File.Exists(this.fn))
                this.LoadFromFile();
        }

        public void Insert()
        {
            Drug d = new Drug();
            d.Input();
            this.drugs.Insert(this.drugs.Count, d);
        }

        public void Insert(Drug d)
        {
            this.drugs.Insert(this.drugs.Count, d);
        }

        public Drug this[int index]
        {
            get {return (Drug)this.drugs[index]; }
        }

        public void LoadFromFile()
        {
            this.drugs.Clear();

            FileStream fs = new FileStream(this.fn, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string name = "", minCost = "", maxCost = "", cost = "";

            while ( (name = sr.ReadLine()) != null )
            {
                minCost = sr.ReadLine();
                maxCost = sr.ReadLine();
                cost    = sr.ReadLine();
                this.Insert(new Drug() { Name = name, MinCost = Convert.ToInt32(minCost), MaxCost = Convert.ToInt32(maxCost), Cost = Convert.ToInt32(cost) });
            }

            sr.Close();
            fs.Close();
        }

        public void SaveToFile()
        {
            FileStream file = new FileStream(this.fn, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            foreach (Drug item in this.drugs)
            {
                writer.WriteLine(item.Name);
                writer.WriteLine(item.MinCost);
                writer.WriteLine(item.MaxCost);
                writer.WriteLine(item.Cost);
            }
            writer.Close();
            file.Close();
        }

        public void Print()
        {
            foreach (Drug item in this.drugs)
            {
                Console.WriteLine(item);
            }
        }
    }
}