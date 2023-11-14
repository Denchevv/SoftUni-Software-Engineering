namespace _11__SpeedRacing
{
    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumption = fuelConsumption;
            TraveledDistance = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; } 
        public double FuelConsumption { get; set; }
        public double TraveledDistance { get; set; }

        public void Drive(double distanceToCover)
        {
            double kmCanCover = FuelAmount / FuelConsumption;
            if(kmCanCover >=  distanceToCover)
            {
                TraveledDistance += distanceToCover;
                FuelAmount -= distanceToCover * FuelConsumption;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
       
    }
    public class Program
    {
        public static void Main()
        {
            int numCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numCars; i++)
            {
                string[] data = Console.ReadLine().Split();

                string model = data[0];
                double fuelAmount = double.Parse(data[1]);
                double fuelConsumption = double.Parse(data[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);  
                cars.Add(car);
            }

            while (true)
            {
                string line = Console.ReadLine();
                if(line == "End")
                {
                    break;
                }

                string[] data = line.Split();              
                string model = data[1];
                double distance = double.Parse(data[2]);
                
                Car car = cars.Find(c=>c.Model == model);
                car.Drive(distance);          
            }

            foreach(Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance:f0}");
            }
        }
    }
}