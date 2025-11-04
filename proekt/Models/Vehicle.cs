using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt.Models
{
    public abstract class Vehicle
    {
        protected Vehicle(string brand, string model, string problem)
        {
            Brand = brand;
            Model = model;
            Problem = problem;
        }

        public string Brand {  get; set; }
        public string Model {  get; set; }
        public string Problem {  get; set; }

        public override string ToString()
        {
            return $"{Brand} - {Model} ({Problem})";
        }
    }
}
