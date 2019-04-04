using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public abstract class Contract
    {
        protected Contract(int id, string name, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}