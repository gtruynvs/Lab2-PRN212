using System.Diagnostics;
using System.Xml.Linq;

namespace Demo2
{
    public class Program
    {
        public class Product
        {
            private string _name;
            private double _price;
            private double _discount;

            public void setName(string name)
            {
                _name = name;
            }

            public string getName()
            {
                return _name;
            }

            public void setPrice(double price)
            {
                _price = price;
            }

            public double getPrice()
            {
                return _price;
            }

            public void setDiscount(double discount)
            {
                _discount = discount;
            }

            public double getDiscount()
            {
                return _discount;
            }

            public Product(string name, int price, float discount)
            {
                _name = name;
                _price = price;
                _discount = discount;
            }

            public Product(string name, int price)
            {
                _name = name;
                _price = price;
                _discount = 0;
            }

            private double getImportTax()
            {
                return _price * 0.1;
            }

            public void display()
            {
                Console.WriteLine("Name: " + _name);
                Console.WriteLine("Price: " + _price);
                Console.WriteLine("Discount: " + _discount);
                Console.WriteLine("Import Tax: " + getImportTax());
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Product 1: ");
            Product pd1 = Input();
            Console.WriteLine();
            Console.WriteLine("Product 2: ");
            Product pd2 = Input();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Display Product: ");
            Console.WriteLine("Product 1:");
            pd1.display();
            Console.WriteLine();
            Console.WriteLine("Product 2:");
            pd2.display();

        }


        public static Product Input()
        {
            Console.Write("Input name: ");
            var name = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.Write("Input price: ");
                    var price = int.Parse(Console.ReadLine());
                    if (price < 0) throw new Exception("Price must >= 0");
                    Console.Write("Add discount? (y/n): ");
                    var isDiscount = Console.ReadLine();
                    if (isDiscount == "y" || isDiscount == "Y")
                    {
                        Console.Write("Input discount: ");
                        var discount = float.Parse(Console.ReadLine());
                        if (name != null)
                        {
                            if (discount > 0)
                            {
                                return new Product(name, price, discount);
                            }
                            else throw new Exception("Discount must >= 0");
                        }
                    }
                    else return new Product(name, price);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }

}


