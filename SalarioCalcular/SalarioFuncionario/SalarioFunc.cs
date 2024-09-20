using SalarioCalcular.Models;

namespace SalarioFuncionario
{
    public class SalarioFunc
    {
        [Fact]
        public void TesteCalcular()
        {
            var f = new FuncionarioSal()
            {
                Salario = 2800,
                Desconto = 500,
                Beneficio = 100
            };

            Assert.Equal(2400, SalarioCalcular.Controllers.FuncionarioController.CalcularGastoFuncionario(f));
        }
    }
}
