namespace VehicleInspection
{
    class Program
    {
        static void Main(string[] args)
        {
            string carBrand = "Audi";
            string carModel = "A6";
            DateTime carProductionDate = new DateTime(2018, 7, 1);
            DateTime carLastInspection = new DateTime(2022, 12, 8);
            Vehicle car = new Car(carBrand, carModel, carProductionDate, carLastInspection);
            car.SetTireType(false); 

            string truckBrand = "Volvo";
            string truckModel = "H6";
            DateTime truckProductionDate = new DateTime(2018, 7, 1);
            DateTime truckLastInspection = new DateTime(2020, 12, 8);
            Vehicle truck = new Truck(truckBrand, truckModel, truckProductionDate, truckLastInspection);
            truck.SetTireType(false);

            Console.WriteLine(car.DisplayInfo());
            Console.WriteLine($"Bilen skal{(car.InspectionStatus() ? "" : " ikke")} synes");
            Console.WriteLine($"Max rim size: {car.MaxRimSize}");

            Console.WriteLine();

            Console.WriteLine(truck.DisplayInfo());
            Console.WriteLine($"Lastbilen skal{(truck.InspectionStatus() ? "" : " ikke")} synes");
            Console.WriteLine($"Max rim size: {truck.MaxRimSize}");

            Console.WriteLine();

            Console.WriteLine(car.GetInterfaceInfo());

            Console.ReadKey();
        }
    }
}
