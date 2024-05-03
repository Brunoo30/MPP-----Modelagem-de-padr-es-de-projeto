using prjVeículos.Components;
using prjVeículos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjVeículos.Builders
{
    class VehicleBuilder : IBuilder
    {
        private Vehicle vehicle = new Vehicle();
        public Vehicle GetVehicle()
        {
            Vehicle result = vehicle;
            Reset();
            return result;
        }
        public void Reset() 
        {
            vehicle = new Vehicle();
        }

        public void SetSeats(int  seats) 
        {
            vehicle.Seats = seats;
        }

        public void SetEngine(Engine engine)
        {
            vehicle.Engine = engine;  
        }

        public void SetTransmission(Transmission transmission) 
        {
            vehicle.Transmission = transmission;
        }

        public void SetVehicle(VehicleType vehicleType) 
        {
            vehicle.VehicleType = vehicleType; 
        }

        public void SetVehicleType(VehicleType vehicleType)
        {
            throw new NotImplementedException();
        }
    }
}
