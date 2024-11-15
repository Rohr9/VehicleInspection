using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInspection
{
    public class Truck : Vehicle
    {
        public Truck(string brand, string model, DateTime productionDate, DateTime lastInspection)
            : base(brand, model, productionDate, lastInspection)
        {
        }

        public override bool InspectionStatus()
        {
            int productionAge = DateTime.Now.Year - ProductionDate.Year;
            int lastInspectionAge = DateTime.Now.Year - LastInspection.Year;

            return productionAge > 1 && lastInspectionAge > 1;
        }

        public override string DisplayInfo()
        {
            return $"Truck: {Brand} {Model}";
        }

        public override void SetTireType(bool isWinterTire)
        {
            MaxRimSize = isWinterTire ? 17 : 20;
        }
    }
}
