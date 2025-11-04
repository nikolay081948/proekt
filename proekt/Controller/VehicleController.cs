using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proekt.Models;

namespace proekt.Controller
{
    public class VehicleController
    {
        private List<Vehicle> Vehicles = new List<Vehicle>();
        public string AddCar(string brand,string model,string problem)
        {
            Vehicles.Add(new Car (brand, model, problem));
            return "Car was added";
        }
        public string AddBus(string brand, string model, string problem)
        {
            Vehicles.Add(new Bus(brand, model, problem));
            return "Bus was added";
        }
        public string AddTruck(string brand, string model, string problem)
        {
            Vehicles.Add(new Truck(brand, model, problem));
            return "Truck was added";
        }
        public string Fix(string brand,string model,string problem)
        {
            var v=Vehicles.FirstOrDefault(x=>x.Brand==brand&&x.Model==model);
            v.Problem = "Fixed";
            return "Vehicle was fixed";
        }
        public List<Vehicle> ShowNotFixed()
        {
            List<Vehicle> list = new List<Vehicle>();
            foreach (var v in Vehicles)
            {
                if(v.Problem!="Fixed")
                    list.Add(v);
            }
            return list;
        }
        public List<Vehicle> ShowAll()
        {
            List<Vehicle> list = new List<Vehicle>();
            foreach (var v in Vehicles)
            {
                
                    list.Add(v);
            }
            return list;
        }
    }
}
