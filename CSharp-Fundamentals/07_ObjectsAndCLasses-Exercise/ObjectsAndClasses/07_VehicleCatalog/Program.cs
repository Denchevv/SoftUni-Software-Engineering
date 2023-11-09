using System.Drawing;

namespace _07_VehicleCatalog
{
    class Truck
    {
        public Truck(string model, string color, double horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
    }
    class Car
    {
        public Car(string model, string color, double horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                string[] data = line.Split();

                string typeVehicle = data[0];
                string model = data[1];
                string color = data[2];
                double horsePower = double.Parse(data[3]);

                if (typeVehicle == "car")
                {
                    Car car = new Car(model, color, horsePower);
                    cars.Add(car);
                }
                else if (typeVehicle == "truck")
                {
                    Truck truck = new Truck(model, color, horsePower);
                    trucks.Add(truck);
                }
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Close the Catalogue")
                {
                    break;
                }
                bool isItCar = cars.Any(x => x.Model == line);

                if (isItCar)
                {
                    int indexOfCar = cars.FindIndex(x => x.Model == line);

                    Console.WriteLine($"Type: Car");
                    Console.WriteLine($"Model: {cars[indexOfCar].Model}");
                    Console.WriteLine($"Color: {cars[indexOfCar].Color}");
                    Console.WriteLine($"Horsepower: {cars[indexOfCar].HorsePower}");
                }

                bool isItTruck = trucks.Any(x => x.Model == line);
                if (isItTruck)
                {
                    int indexOfTruck = trucks.FindIndex(x => x.Model == line);

                    Console.WriteLine("Type: Truck");
                    Console.WriteLine($"Model: {trucks[indexOfTruck].Model}");
                    Console.WriteLine($"Color: {trucks[indexOfTruck].Color}");
                    Console.WriteLine($"Horsepower: {trucks[indexOfTruck].HorsePower}");

                }
            }

            double carsAvrgHorsePower = cars.Sum(x => x.HorsePower) / cars.Count;
            double trucksAvrgHorsePower = trucks.Sum(x => x.HorsePower) / trucks.Count;

            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carsAvrgHorsePower:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {trucksAvrgHorsePower:f2}.");

            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
}