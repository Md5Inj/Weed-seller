using System;

namespace Weed {
    class Seller {
        private string Name { get; set; }
        private double Wallet { get; }
        private Drugs Inventory { get; }
        private Band Band { get; }
        private int GunsAmount { get; set; }
        private double ToDealer { get; set;}
        public Seller(string name, double moneyCount, double toDealer)
        {
            this.Name = name;
            this.Wallet = moneyCount;
            this.ToDealer = toDealer;
            this.Inventory = null;
            this.Band = null;
            this.GunsAmount = 0;
        }
    }
}