using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class HeatContract : Contract
    {
        public List<double> TemperatureSet;

        public HeatContract(int id, string name, double price, List<double> temperatureSet) : base(id, name, price)
        {
            this.TemperatureSet.AddRange(temperatureSet);
        }
    }
}