using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantStudio
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        //(appetizer, main course, or dessert)
        public string Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(string name, double price, string description, string category, bool isNew)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }

        // Override the default ToString() method
        // More info here: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-override-the-tostring-method
        public override string ToString()
        {
            var newText = "";
            if (IsNew)
            {
                newText = "New!";
            }
            return String.Format("{0} - ${1} - {2} ({3}) {4}", Name, Price,  Description, Category, newText);
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
        
            //cast to MenuItem
            MenuItem menuItem = (MenuItem)obj;



            //check for null
            //check for value equality
            //return a bool result
            return this.Name == menuItem.Name && this.Category == menuItem.Name;

        }
    }
}
