using System;

namespace Task0111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;
            do
            {
                Console.Write("Enter FullName: ");
                string fullName = Console.ReadLine();

                Console.Write("Enter BirthDate: ");
                DateTime birthDate;
                bool isBirthDateValid = DateTime.TryParse(Console.ReadLine(), out birthDate);

                Console.Write("Enter Group No: ");
                string groupNo = Console.ReadLine();

                Console.Write("Enter Point: ");
                int point;
                bool isPointValid = int.TryParse(Console.ReadLine(), out point);

                if (isBirthDateValid && isPointValid)
                {
                    Student student = new Student(fullName, birthDate, groupNo, point);

                    student.ShowInfo();

                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Please enter valid information!!.");
                }
            } while (!isValid);

            ///////////////////////////////////////////////////////////////////////

            Console.Write("Enter Product Count: ");
            int productCount;

            while (!int.TryParse(Console.ReadLine(), out productCount) || productCount <= 0)
            {
                Console.WriteLine("Invalid count!! Please enter a positive count .");
            }

            Product[] products = new Product[productCount];
            for (int i = 0; i < productCount; i++)
            {
                string productName;

                do
                {
                    Console.Write($"Enter the name for product {i + 1}: ");
                    productName = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(productName))
                    {
                        Console.WriteLine(" Product name is not correct! Enter again!!.");
                    }
                } while (string.IsNullOrWhiteSpace(productName));

                double productPrice;
                do
                {
                    Console.Write($"Enter the price for product {i + 1}: ");
                }
                while (!double.TryParse(Console.ReadLine(), out productPrice) || productPrice < 0);

                products[i] = new Product(productName, productPrice);

            }
            if (productCount > 0)
            {
                double totalPrice = 0;
                string mostExpensiveProductName = products[0].Name;
                string cheapestProductName = products[0].Name;

                int mostExpensiveProduct = 0;
                int cheapestProduct = 0;

                for (int i = 0; i < productCount; i++)
                {
                    totalPrice += products[i].Price;

                    if (products[i].Price > products[mostExpensiveProduct].Price)
                    {
                        mostExpensiveProduct = i;
                    }

                    if (products[i].Price < products[cheapestProduct].Price)
                    {
                        cheapestProduct = i;
                    }
                }
                double averagePrice = totalPrice / productCount;
                Console.WriteLine($"\nAverage Price: {averagePrice}");
                Console.WriteLine($"Most Expensive Product: {products[mostExpensiveProduct].Name}");
                Console.WriteLine($"Cheapest Product: {products[cheapestProduct].Name}");
            }
            else
                Console.WriteLine("No products for average");

        }
        }
    }

