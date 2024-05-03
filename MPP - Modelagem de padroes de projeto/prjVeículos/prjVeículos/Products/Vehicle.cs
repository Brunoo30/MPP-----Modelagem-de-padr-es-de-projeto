using prjVeículos.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjVeículos.Products
{
    class Vehicle
    {
        private VehicleType vehicleType;
        private int seats;
        private Engine engine;
        private Transmission transmission;

        public VehicleType VehicleType
        {
            get => VehicleType;
            set => VehicleType = value;
        }
        public int Seats 
        { 
            get => seats; 
            set => seats = value; 
        }
        public Engine Engine 
        { 
            get => engine; 
            set => engine = value; 
        }
        public Transmission Transmission 
        { 
            get => transmission; 
            set => transmission = value; 
        }

    }
}
