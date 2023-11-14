using System.Drawing;
using System.Reflection;

namespace _17_VehicleCatalog
{
    class Truck
    {
        public Truck(string model, string color, int horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
    class Car
    {
        public Car(string model, string color, int horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

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

                    string vehicleType = data[0];
                    string model = data[1];
                    string color = data[2];
                    int horsePower = int.Parse(data[3]);

                    if (vehicleType == "truck")
                    {
                        Truck truck = new Truck(model, color, horsePower);
                        trucks.Add(truck);
                    }
                    else if (vehicleType == "car")
                    {
                        Car car = new Car(model, color, horsePower);
                        cars.Add(car);
                    }
                }

                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "Close the Catalogue")
                    {
                        break;
                    }

                    bool isItACar = cars.Any(x => x.Model == input);
                    if (isItACar)
                    {
                        int indexOfCar = cars.FindIndex(x => x.Model == input);
                        Console.WriteLine("Type: Car");
                        Console.WriteLine($"Model: {cars[indexOfCar].Model}");
                        Console.WriteLine($"Color: {cars[indexOfCar].Color}");
                        Console.WriteLine($"Horsepower: {cars[indexOfCar].HorsePower}");
                    }

                    bool isItATruck = trucks.Any(x=>x.Model == input);
                    if(isItATruck)
                    {
                        int indexOfTruck = trucks.FindIndex(x=>x.Model == input);
                        Console.WriteLine("Type: Truck");
                        Console.WriteLine($"Model: {trucks[indexOfTruck].Model}");
                        Console.WriteLine($"Color: {trucks[indexOfTruck].Color}");
                        Console.WriteLine($"Horsepower: {trucks[indexOfTruck].HorsePower}");
                    }
                }

                double avgCarHrsPower = (double)cars.Sum(x=>x.HorsePower) / cars.Count();
                double avgTruckHrsPower = (double)trucks.Sum(x=>x.HorsePower) / trucks.Count();

                Console.WriteLine($"Cars have average horsepower of: {avgCarHrsPower:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {avgTruckHrsPower:f2}.");
            }
        }
    }
}