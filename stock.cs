using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace baitntackle
{
    class stock
    {

        Dictionary<string, item> stockList = new Dictionary<string, item>();


        public void AddItem()
        {
            Clear();

            WriteLine("ID: ");
            var keyString = ReadLine();

            WriteLine("Namn: ");
            var itemName = ReadLine();


            WriteLine("Description: ");
            var description = ReadLine();


            WriteLine("Price: ");
            int price = int.Parse(ReadLine());

            item tempItem = new item(name: itemName, description: description, price: price);

            stockList.Add(keyString, tempItem);


        }

        public void VeiwDeleteItem()
        {
            Clear();

            WriteLine("ID".PadRight(5, ' ') + "Product".PadRight(5, ' ') + "Price".PadRight(5, ' '));
            WriteLine(" ".PadLeft(55, '-'));

            foreach (var item in stockList)
            {
                WriteLine(item.Key + "    " + item.Value.ToString());
            }

            WriteLine("S to show D to delete");

            WriteLine("Press any key to return");
            ReadKey();

            ConsoleKeyInfo keyPressed = ReadKey(true);

            switch (keyPressed.Key)
            {

                case ConsoleKey.S:
                   
                    Clear();

                    WriteLine("ID".PadRight(5, ' ') + "Product".PadRight(5, ' ') + "Price".PadRight(5, ' '));
                    WriteLine(" ".PadLeft(55, '-'));

                    foreach (var item in stockList)
                    {
                        WriteLine(item.Key + "    " + item.Value.ToString());
                    }

                    WriteLine("Enter ID to show: ");
                    var keyString = ReadLine();

                    Clear();
                    item tempItem = (stockList[keyString]);

                    WriteLine("ID: " + keyString);
                    WriteLine("Name: " + tempItem.Name);
                    WriteLine("Description: " + tempItem.Description);
                    WriteLine("Price: " + tempItem.Price);


                    WriteLine("Press any key to exit to menu");
                    ReadKey();

                    break;

                case ConsoleKey.D:

                    Clear();

                    WriteLine("ID".PadRight(5, ' ') + "Product".PadRight(5, ' ') + "Price".PadRight(5, ' '));
                    WriteLine(" ".PadLeft(55, '-'));

                    foreach (var item in stockList)
                    {
                        WriteLine(item.Key + "    " + item.Value.ToString());
                    }

                    WriteLine("Enter ID to delete: ");
                    var keyString1 = ReadLine();

                    stockList.Remove(keyString1);

                    WriteLine("Item {0} deleted.", keyString1);
                    ReadKey();

                    break;

                default:


                    break;

            }

        }


    }



}

