using API.Models.Electricity_contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class ElectricityContract : Contract
    {
        private BuildingType buildingType;

        public ElectricityContract(string name, double price, BuildingType buildingType) : base(name, price)
        {
            this.BuildingType = buildingType;
        }

        public BuildingType BuildingType
        {
            get => buildingType;

            set
            {
                try
                {
                    buildingType = value;
                }
                catch(ArgumentException e)
                {
                    throw new ArgumentException("Your building type does not exist.", e);
                }
            }
        }

        public override Contract GetContract()
        {
            throw new NotImplementedException();
        }
    }
}