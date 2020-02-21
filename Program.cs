using System;

namespace universitaetsbibliothek
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemFactory factory = null;
            Console.Write("Enter the name of the book/magazine you want to create: ");
            string factoryItem = Console.ReadLine();

            switch (factoryItem.ToLower())
            {
                case "book":
                    factory = new BookFactory("HRIE3423235", "James Cameron");
                    break;
                case "magazine":
                    factory = new MagazineFactory("787263492ASF", "TOP MAGAZIN.DE");
                    break;
                default:
                    break;
            }

            Item item = factory.GetItem();
            Console.WriteLine("Your item details below: \n");
            Console.WriteLine($"Publisher: {item.ItemPublisher}, ISBN/ISSN: {item.ItemIdendifier}");
            Console.ReadKey();
        }
    }
}