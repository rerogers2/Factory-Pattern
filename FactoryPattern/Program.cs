namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ask the user for the number of wheels to create the vehicle
            Console.WriteLine("How many wheels would you like on your vehicle?");
            string wheels = Console.ReadLine();

            // create the vehicle based on the number of wheels
            IVehicle vehicle = VehicleFactory.GetVehicle(wheels);
            vehicle.Drive();
        }
    }
}
