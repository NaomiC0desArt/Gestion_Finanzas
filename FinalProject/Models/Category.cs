using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public class Category
	{
		public int Id { get; set; }
		public required string Name { get; set; }
		public decimal Limit { get; set; } = 0m;

		// relaciones
		public ICollection<Transaction>? Transactions { get; set; } = new List<Transaction>();
	}
}
