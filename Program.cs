using System;
using System.Collections.Generic;


namespace Lab_5._3
{

    class Car
    {
        
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public Decimal price { get; set; }

        public Car()
        {

        }

        public Car(string Make, string Model, int Year, Decimal Price)
        {
            make = Make;
            model = Model;
            year = Year;
            price = Price;
        }

        public override string ToString() // may need to change
        {
            return $"{make} {model} {year}. ${price}";
        }
    }

    class UsedCar : Car
    {
        public double mileage { get; set; }

        public UsedCar(string Make, string Model, int Year, Decimal Price, double Mileage) : base(Make,  Model,  Year, Price)
        {
            mileage = Mileage;
        }

        public override string ToString() // may need to change
        {
            return $"{make} {model} {year}. ${price} (Used) {mileage} miles";
        }


    }

    class CarLot
    {
        public static List<Car> carLot = new List<Car>();

        public static void AddCar(Car acar) // Car is getting a car from the car class
        {
            carLot.Add(acar);
        }

        public static void RemoveCar(Car acar)
        {
            carLot.Remove(acar);
        }

        public static void PrintCar()
        {
            Console.WriteLine($"There are {CarLot.carLot.Count} cars."); // Prints the number of cars in the list

            foreach (var car in CarLot.carLot)
            {
                Console.WriteLine(car);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gtant Chirpus' Used Car Emporium!");

            Car car1 = new Car("Nikolai", "Model S", 2017, 54999.90m);
            Car car2= new Car("Fourd", "Escapade", 2017, 31999.90m);
            Car car3 = new Car("Chewie", "Vette", 2017, 44989.95m);
            Car used1 = new UsedCar("Hyonda", "Prior", 2015, 14795.50m, 35987.6);
            Car used2 = new UsedCar("GC", "Chirpus", 2013, 8500.00m, 12345.0);
            Car used3 = new UsedCar("GC", "asegtqa", 2016, 14450.00m, 3500.3);

            CarLot.AddCar(car1);
            CarLot.AddCar(car2);
            CarLot.AddCar(car3);
            CarLot.AddCar(used1);
            CarLot.AddCar(used2);
            CarLot.AddCar(used3);

            CarLot.PrintCar();

           // CarLot.RemoveCar(car1);

           // CarLot.PrintCar();

        }
    }
}




