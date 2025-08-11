using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public enum CategoryType
	{
		Ingreso = 0,
		Gasto = 1
	}
	public class Category
	{
		public int Id { get; set; }
		public required string Name { get; set; }
		public decimal Limit { get; set; } = 0m;
		public CategoryType Type { get; set; } = CategoryType.Gasto;
		// relaciones
		public ICollection<Transaction>? Transactions { get; set; } = new List<Transaction>();
	}
}
