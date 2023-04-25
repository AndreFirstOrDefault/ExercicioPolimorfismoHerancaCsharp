using ExercicioDeFixacaoAula142.Entities;
using System.Globalization;

namespace ExercicioDeFixacaoAula142
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Product #" + (i+1) + " data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char op = char.Parse(Console.ReadLine());

                if(op == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                }

                if (op == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new Product(name, price));
                }

                if(op == 'u')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine()); 
                    products.Add(new UsedProduct(name, price, date));
                }


            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(Product product in products)
            {
                Console.WriteLine(product.priceTag());
            }

        }
    }
}
