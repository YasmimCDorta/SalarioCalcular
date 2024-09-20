using Microsoft.AspNetCore.Mvc;
using SalarioCalcular.Models;

namespace SalarioCalcular.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calcular(FuncionarioSal funcionario)
        {
            if (ModelState.IsValid)
            {
                var gastoFuncionario = CalcularGastoFuncionario(funcionario);
                ViewData["GastoFuncionario"] = gastoFuncionario;
            }

            return View("Index", funcionario);
        }

        public static decimal CalcularGastoFuncionario(FuncionarioSal funcionario)
        {
            return funcionario.Salario + funcionario.Beneficio - funcionario.Desconto;
        }
    }
}

