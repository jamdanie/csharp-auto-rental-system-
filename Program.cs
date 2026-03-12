using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRental
{
    // This is an Auto Rental business database - single user
    // This rental business specilizes in exootic and muscle cars from the 70s/80s
    // It is to keep track of the cars that this rental shop has in inventory to rent
    // It will also keep track of prices for renting for the day for each car
    // The data object class for the Car objects will follow the paradigm of POCO
    // or Plain Old C# (CLR)
    internal class Program //: object 
    {
        // Main will function as the test driver just to verify if the POCO class is working
        // and we get basic input and oputput functionality for the car database
        static void Main(string[] args)
        {
            Console.WriteLine("BEGIN AutoRental program");

            // Create Car object - each object should have the parameters of a car for rent
            Car car1 = new Car();


            // INPUT section ////////////////////////////////////////////////////
            // Define what a car is 
            // Determine the manufacture year of the car
            car1.Year = 1965;
            // Determine the color of the car
            car1.PaintColor = "Black";
            // Determine the make-model of the car
            car1.MakeModel = "Ford Mustang 2+2";
            // Determine the rental price for one day of the car
            car1.RentalPrice = 79.99m;

            // James xmas wish-list
            Car car2 = new Car(1971, "Chocolate Brown", "Pontiac GTO", 69.99m);
            Car car3 = new Car(1979, "Red", "Ferrari Boxer", 159.99m);
            Car car4 = new Car(1980, "Silver", "Porsche 911 Turbo", 129.99m);

            // OUTPUT section /////////////////////////////////////////////////////
            Console.WriteLine("***********Auto inventory: ");
            Console.WriteLine($" Year:  {car1.Year}");
            Console.WriteLine($"Color: {car1.PaintColor}");
            Console.WriteLine($"Model: {car1.MakeModel}");
            Console.WriteLine($"Daily: {car1.RentalPrice}");

            // now output all the infor for car2
            Console.WriteLine("***********Auto inventory: ");
            Console.WriteLine($" Year:  {car2.Year}");
            Console.WriteLine($"Color: {car2.PaintColor}");
            Console.WriteLine($"Model: {car2.MakeModel}");
            Console.WriteLine($"Daily: {car2.RentalPrice}");

            // James xmas wish-list for data output from an existing car object
            Console.WriteLine(car3);
            Console.WriteLine(car4);

            Console.WriteLine("**END AutoRental program");
        }
    }
}
