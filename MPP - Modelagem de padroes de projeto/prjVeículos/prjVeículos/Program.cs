using prjVeículos.Builders;
using prjVeículos.Directors;
using prjVeículos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjVeículos
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ConstructSedanCar();
            Vehicle sedan = builder.GetVehicle();
            Console.WriteLine($"Criando um ´veículo do tipo: {sedan.VehicleType}");

            director.ConstructTruck();
            Vehicle truck = builder.GetVehicle();
            Console.WriteLine($"Criando um veículo do tipo:{truck.VehicleType}");

            Console.ReadLine();
        }
    }
}
