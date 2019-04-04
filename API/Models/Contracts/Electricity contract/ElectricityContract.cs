using API.Models.Electricity_contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class ElectricityContract : Contract
    {
        public ElectricityContract(int id, string name, double price, BuildingType buildingType) : base(id, name, price)
        {
            this.BuildingType = buildingType.ToString();
        }

        public string BuildingType { get; set; }
    }
}