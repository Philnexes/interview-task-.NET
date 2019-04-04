using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers.ContractsControllers
{
    public class HeatContractController : ApiController
    {
        Contract[] heatContracts = new Contract[]
        {
            new HeatContract(1, "Heat contract #1", 130.00, new List<double> { 10.00, 15, 20.50, 25, 25, 30.30, 10, 40.99 })
        };

        public IEnumerable<Contract> GetAllHeatContracts()
        {
            return heatContracts;
        }

        public IHttpActionResult GetHeatContract(int id)
        {
            var contract = heatContracts.FirstOrDefault(c => c.Id == id);

            return contract == null ? NotFound() : (IHttpActionResult)Ok(contract);
        }
    }
}