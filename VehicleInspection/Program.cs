namespace VehicleInspection
{
    class Program
    {
        static void Main(string[] args)
        {
            string carBrand = "Audi";
            string carModel = "A8";
            DateTime carProductionDate = new DateTime(2018, 7, 1);
            DateTime carLastInspection = new DateTime(2022, 12, 8);
            Vehicle car = new Car(carBrand, carModel, carProductionDate, carLastInspection);

            string truckBrand = "Volvo";
            string truckFuelLevel = "H6";
            DateTime truckProductionDate = new DateTime(2018, 7, 1);
            DateTime truckLastInspection = new DateTime(2022, 12, 8);
            Vehicle truck = new Car(truckBrand, truckFuelLevel, truckProductionDate, truckLastInspection);

            Console.WriteLine(car.DisplayInfo());
            Console.WriteLine(car.InspectionStatus());
            Console.WriteLine();
            Console.WriteLine(truck.DisplayInfo());
            Console.WriteLine(truck.InspectionStatus());
            Console.ReadKey();

        }
    }
}
