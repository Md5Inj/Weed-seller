using System;
using System.IO;

namespace Weed {
    class Settings {
        private string fn = "settings";
        public ConsoleColor Color {get; set;}
        public string Currency {get; set;}

        public Settings(ConsoleColor color, string currency)
        {
            this.Color = color;
            this.Currency = currency;
        }

        public Settings()
        {
            if (File.Exists(this.fn))
            {
                this.LoadFromFile();
                Console.ForegroundColor = this.Color;
            }
        }

        public void LoadFromFile()
        {
            FileStream fs = new FileStream(this.fn, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            this.Currency = sr.ReadLine();
            this.Color = (ConsoleColor)Convert.ToInt32(sr.ReadLine());
            
            fs.Close();
            sr.Close();
        }

        public void SaveToFile()
        {
            FileStream fs = new FileStream(this.fn, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);

            writer.WriteLine(this.Currency);
            writer.WriteLine((int)this.Color);

            writer.Close();
        }
    }
}