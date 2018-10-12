using Cars.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            Console.WriteLine("Input 1st Car Name: ");
            car1.Name = Console.ReadLine();
            Console.WriteLine("Input 1st Car Colour: ");
            car1.Colour = Console.ReadLine();
            Console.WriteLine("Input 1st Car Price: ");
            car1.Price = double.TryParse(Console.ReadLine(), out _price);
            Console.WriteLine("Input discount for this model: ");
            car1.Discount = double.Parse(Console.ReadLine());
            if (car1.Discount >0 && car1.Discount <= 1)
            {
                Console.WriteLine($"Price with discount: {car1.Price - (car1.Price * car1.Discount)}");
            }
            else Console.WriteLine("No Discount");

            Console.WriteLine("Input 2nd Car Name: ");
            car2.Name = Console.ReadLine();
            Console.WriteLine("Input 2nd Car Colour: ");
            car2.Colour = Console.ReadLine();
            Console.WriteLine("Input 2nd Car Price: ");
            car2.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Input discount for this model: ");
            car2.Discount = double.Parse(Console.ReadLine());
            Console.WriteLine("Input discount for this model: ");
            car2.Discount = double.Parse(Console.ReadLine());
            if (car2.Discount > 0 && car1.Discount <= 1)
            {
                Console.WriteLine($"Price with discount: {car2.Price - (car2.Price * car2.Discount)}");
            }
            else Console.WriteLine("No Discount");


            Console.WriteLine("Input 3rd Car Name: ");
            car3.Name = Console.ReadLine();
            Console.WriteLine("Input 3rd Car Colour: ");
            car3.Colour = Console.ReadLine();
            Console.WriteLine("Input 3rd Car Price: ");
            car3.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Input discount for this model: ");
            car3.Discount = double.Parse(Console.ReadLine());
            Console.WriteLine("Input discount for this model: ");
            car3.Discount = double.Parse(Console.ReadLine());
            if (car3.Discount > 0 && car1.Discount <= 1)
            {
                Console.WriteLine($"Price with discount: {car3.Price - (car3.Price * car3.Discount)}");
            }
            else Console.WriteLine("No Discount");


        }
    }

   
}
