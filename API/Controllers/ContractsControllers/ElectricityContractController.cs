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
            new ElectricityContract(1, "Electricity contract #1", 200.50, BuildingType.Flat)
        };

        public IEnumerable<Contract> GetAllElectricityContracts()
        {
            return electricityContracts;
        }

        public IHttpActionResult GetElectricityContract(int id)
        {
            var contract = electricityContracts.FirstOrDefault(c => c.Id == id);

            return contract == null ? NotFound() : (IHttpActionResult)Ok(contract);
        }
    }
}