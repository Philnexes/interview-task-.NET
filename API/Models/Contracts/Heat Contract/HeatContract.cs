using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class HeatContract : Contract
    {
        public List<double> TemperatureSet;

        public HeatContract(string name, double price, List<double> temperatureSet) : base(name, price)
        {
            TemperatureSet = temperatureSet;
        }

        public override Contract GetContract()
        {
            throw new NotImplementedException();
        }
    }
}