using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_Model.Models
{
	public class Inventory
	{
		[Key]
		public int Inventory_Id { get; set; }
		public int Stock { get; set; }

		[ForeignKey("Product")]
		public int Product_Id { get; set; }
		public Product Product { get; set; }
	}
}
