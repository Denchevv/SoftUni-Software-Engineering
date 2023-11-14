namespace _13_RawData
{
    class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }
    }
    class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }

    }
    class Car
    {
        public string Model { get; set; }
        public Engine CarEngine { get; set; }
        public Cargo CarCargo { get; set; }

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
        {
            Model = model;
            CarEngine = new Engine { Power = enginePower, Speed = engineSpeed };
            CarCargo = new Cargo { Type = cargoType, Weight = cargoWeight };
        }

        public class Program
        {
            public static void Main()
            {
                int n = int.Parse(Console.ReadLine());
                List<Car> cars = new List<Car>();

                for (int i = 0; i < n; i++)
                {
                    string[] data = Console.ReadLine().Split();

                    string model = data[0];
                    int engineSpeed = int.Parse(data[1]);
                    int enginePower = int.Parse(data[2]);
                    int cargoWeight = int.Parse(data[3]);
                    string type = data[4];

                    Car car = new Car(model, engineSpeed, enginePower, cargoWeight, type);
                    cars.Add(car);
                }

                string command = Console.ReadLine();

                if(command == "fragile")
                {
                    foreach (Car car in cars.Where(x => x.CarCargo.Type == "fragile"
                                                   && x.CarCargo.Weight < 1000))

                    {
                        Console.WriteLine(car.Model);
                    }
                }
                else if(command =="flamable")
                {
                    foreach (Car car in cars.Where(x=>x.CarCargo.Type == "flamable" &&
                                                    x.CarEngine.Power > 250))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}