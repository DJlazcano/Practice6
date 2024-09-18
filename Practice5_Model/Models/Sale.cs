using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_Model.Models
{
	public class Sale
	{
		[Key]
		public int Sale_Id { get; set; }
		public double QuantitySold { get; set; }
		public DateTime SaleDate { get; set; }
		public double SalePrice { get; set; }
		public double TotalAmount { get; set; }

		public string CustomerName { get; set; }


		[ForeignKey("Product")]
		public int Product_Id { get; set; }
		public Product Product { get; set; }
	}
}
