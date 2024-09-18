using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_Model.Models
{
	public class Purchase
	{
		[Key]
		public int Purchase_Id { get; set; }
		public int QuantityPurchased { get; set; }

        public double PurchasePrice { get; set; }

		public DateTime PurchaseDate { get; set; }

		public double TotalCost { get; set; }

		[ForeignKey("Product")]
		public int Product_Id { get; set; }
        public Product Product { get; set; }
    }
}
