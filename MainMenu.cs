using System;

namespace Weed {
    class MainMenu {
        public string Name {get; set;}
        public void ColorWrite(string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        private void inputName()
        {
            Console.Clear();
            Console.WriteLine("Введите ваше имя: ");
            this.Name = Console.ReadLine();
        }

        private void ShowMenu()
        {
            Console.WriteLine("1 - новая игра");
            Console.WriteLine("2 - загрузка сохранения");
            Console.WriteLine("3 - настройки");
            Console.WriteLine("4 - рекорды");
            Console.WriteLine("0 - выход");
        }

        public MainMenu() {
            ConsoleKeyInfo input;
            do
            {
                this.ShowMenu();
                input = Console.ReadKey();
                switch (input.Key) {
                    case ConsoleKey.D0: break;
                    case ConsoleKey.D1:
                        this.inputName();
                        input = new ConsoleKeyInfo((char)ConsoleKey.D0,ConsoleKey.D0, false, false, false);
                        break;
                    case ConsoleKey.D2:
                        Drugs d = new Drugs();
                        d.Print();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("Key 3 pressed"); break;
                    case ConsoleKey.D4:
                        Console.WriteLine("Key 4 pressed"); break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (input.Key != ConsoleKey.D0);
        }
    }
}