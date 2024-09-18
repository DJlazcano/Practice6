using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_Model.Models
{
	public class Product
	{
		[Key]
		public int Product_Id { get; set; }
		public string ProductName { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }

		public int QuantityInStock { get; set; }

		public ICollection<Sale> Sales { get; set; }
		public ICollection<Purchase> Purchases { get; set; }
	}
}
