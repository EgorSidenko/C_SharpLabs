using System;

namespace lab03lib_Seva
{
        // Parent class
        public abstract class Printed_Edition
        {
            //Stores the name of object
            private string name;
            //Stores number of pages of the object
            private int pages;
            //Stores number of chapters of the object
            private int chapters;
            //Stores price of the object
            private double price;
            //Stores quantity of the object
            private int quantity;

            //name properties
            public string Name
            {
                get { return name; }
                set
                {
                    if (value == "")
                        throw new ArgumentNullException();
                    else
                        name = value;
                }
            }

            //pages properties
            public int Pages
            {
                get { return pages; }
                set
                {
                    if (value < 0)
                        throw new ArgumentOutOfRangeException();
                    else
                        pages = value;
                }
            }

            //chapters properties
            public int Chapters
            {
                get { return chapters; }
                set
                {
                    if (value < 0)
                        throw new ArgumentOutOfRangeException();
                    else
                        chapters = value;
                }
            }

            //price properties
            public double Price
            {
                get { return price; }
                set
                {
                    if (value < 0)
                        throw new ArgumentOutOfRangeException();
                    else
                        price = value;
                }
            }

            //quantity prorperties
            public int Quantity
            {
                get { return quantity; }
                set
                {
                    if (value < 0)
                        throw new ArgumentOutOfRangeException();
                    else
                        quantity = value;
                }
            }

            //returns string with information about the objects
            public virtual string GetInfo()
            {
                return $"{name} has {pages} pages, {chapters} chapters, costs {price} and there are {quantity} copies of it";
            }

            //Default constructor
            public Printed_Edition()
            {

            }

            //Constructor that sets name
            public Printed_Edition(string Name)
            {
                this.Name = Name;
            }

            //Constructor that sets pages and chapters
            public Printed_Edition(int Pages, int Chapters)
            {
                this.Pages = Pages;
                this.Chapters = Chapters;
            }

            //Constructor that sets price and quantity
            public Printed_Edition(double Price, int Quantity)
            {
                this.Price = Price;
                this.Quantity = Quantity;
            }

        }

        //Child class
        public class Book : Printed_Edition
        {
            //Overriden function to get information
            public override string GetInfo()
            {
                return base.GetInfo();
            }

            //Default constructor
            public Book() : base()
            {

            }

            //Constructor that sets name
            public Book(string Name) : base(Name)
            {

            }

            //Constructor that sets pages and chapters
            public Book(int Pages, int Chapters) : base(Pages, Chapters)
            {

            }

            //Constructor that sets price and quantity
            public Book(double Price, int Quantity) : base(Price, Quantity)
            {

            }
        }

        //Child class
        public class Magazine : Printed_Edition
        {
            //Overriden function to get information
            public override string GetInfo()
            {
                return base.GetInfo();
            }

            //Default constructor
            public Magazine() : base()
            {

            }

            //Constructor that sets name
            public Magazine(string Name) : base(Name)
            {

            }

            //Constructor that sets pages and chapters
            public Magazine(int Pages, int Chapters) : base(Pages, Chapters)
            {

            }

            //Constructor that sets price and quantity
            public Magazine(double Price, int Quantity) : base(Price, Quantity)
            {

            }
        }
}