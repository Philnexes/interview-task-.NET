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
            new HeatContract(1, "Heat contract #1", 130.00, new List<double> { 10.00, 15, 20.50, 25, 25, 30.30, 10, 40.99 }),
            new HeatContract(2, "Heat contract #2", 135.50, new List<double> { 10.00, 15, 40.99 })
        };

        /// <summary>
        /// Method that returns all the heat contracts as an IEnumerable type
        /// </summary>
        /// <returns>All heat contracts</returns>
        public IEnumerable<Contract> GetAllHeatContracts()
        {
            return heatContracts;
        }

        /// <summary>
        /// Method that looks up for a single heat contract based on its ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Heat contract info</returns>
        public IHttpActionResult GetHeatContract(int id)
        {
            var contract = heatContracts.FirstOrDefault(c => c.Id == id);

            return contract == null ? NotFound() : (IHttpActionResult)Ok(contract);
        }
    }
}