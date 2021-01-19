using System;
using static System.Console;

namespace baitntackle
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }


        static void Menu()
        {

            stock allStock = new stock();

            bool shouldNotExit = true;

            while (shouldNotExit)
            {

                Clear();


                WriteLine("1.Add product");
                WriteLine("2.List products");
                WriteLine("3.Exit");


                ConsoleKeyInfo keyPressed = ReadKey(true);


                switch (keyPressed.Key)
                {

                    case ConsoleKey.D1:
                        allStock.AddItem();

                        break;

                    case ConsoleKey.D2:
                        Clear();

                        allStock.VeiwDeleteItem();
                        break;

                    case ConsoleKey.D3:

                        shouldNotExit = false;

                        break;

                }

            }
        }
    }
}
