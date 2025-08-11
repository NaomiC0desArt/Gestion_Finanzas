using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
	public enum TransactionType
	{
		Ingresos = 0,
		Gastos = 1
	}

	public class Transaction
	{
		public int Id { get; set; }
		public decimal Amount { get; set; }
		public string? Description { get; set; }
		public DateTime Date { get; set; }

		public TransactionType Type { get; set; }

		// ingresos pueden no tener categoría
		public int? CategoryId { get; set; }
		public Category? Category { get; set; }
	}
}
