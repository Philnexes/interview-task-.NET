using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public abstract class Contract
    {
        protected Contract(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public abstract Contract GetContract();
    }
}