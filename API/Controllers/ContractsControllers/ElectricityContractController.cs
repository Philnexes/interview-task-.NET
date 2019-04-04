using API.Models;
using API.Models.Electricity_contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers.ContractsControllers
{
    public class ElectricityContractController : ApiController
    {
        Contract[] electricityContracts = new Contract[]
        {
            new ElectricityContract(1, "Electricity contract #1", 200.50, BuildingType.Flat),
            new ElectricityContract(2, "Electricity contract #2", 20, BuildingType.House),
            new ElectricityContract(3, "Electricity contract #3", 300, BuildingType.Other),
            new ElectricityContract(4, "Electricity contract #4", 180.4, BuildingType.Other)
        };

        /// <summary>
        /// Method that returns all the electricity contracts as an IEnumerable type
        /// </summary>
        /// <returns>All elecricity contracts</returns>
        public IEnumerable<Contract> GetAllElectricityContracts()
        {
            return electricityContracts;
        }

        /// <summary>
        /// Method that looks up for a single eletricity contract based on its ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Electricity contract info</returns>
        public IHttpActionResult GetElectricityContract(int id)
        {
            var contract = electricityContracts.FirstOrDefault(c => c.Id == id);

            return contract == null ? NotFound() : (IHttpActionResult)Ok(contract);
        }
    }
}