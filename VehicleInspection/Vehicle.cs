using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInspection
{
    public abstract class Vehicle : IWheels
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime LastInspection { get; set; }
        public int MaxRimSize { get; set; }

        protected Vehicle(string brand, string model, DateTime productionDate, DateTime lastInspection)
        {
            Brand = brand;
            Model = model;
            ProductionDate = productionDate;
            LastInspection = lastInspection;
        }

        public abstract bool InspectionStatus();

        public virtual string DisplayInfo()
        {
            return $"{Brand} {Model}";
        }

        public string GetInterfaceInfo()
        {
            return ((IWheels)this).Info();
        }

        public abstract void SetTireType(bool isWinterTire);
    }
}
