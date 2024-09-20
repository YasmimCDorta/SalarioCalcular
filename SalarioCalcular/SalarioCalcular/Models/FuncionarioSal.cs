using System.ComponentModel.DataAnnotations;

namespace SalarioCalcular.Models
{
	public class FuncionarioSal
	{
		public string Nome { get; set; }
		public decimal Salario { get; set; }
		public decimal Desconto { get; set; }
		public decimal Beneficio { get; set; }
	}
}
