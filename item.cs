using System;
using System.Collections.Generic;
using System.Text;

namespace baitntackle
{
    class item
    {
        int price;
        string description;
        string name;

        public item(string name, string description, int price)
        {

            this.Name = name;
            this.Description = description;
            this.Price = price;

        }

        public int Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return Name + "                     " +  Price; 
        }

    }
}
