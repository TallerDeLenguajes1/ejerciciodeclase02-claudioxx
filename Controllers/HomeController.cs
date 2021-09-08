using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaBancario.Entidades;
using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBancario.Controllers
{
	public enum tipoExtraccion
	{
		CajeroHumano = 1,
		CajeroAutomatico = 2
	}
	public class HomeController : Controller
	{
		
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			Cuenta Cuenta1 = new CCenPesos(300000);
			Cuenta Cuenta2 = new CCenDolares(200000);
			Cuenta Cuenta3 = new cajaDeAhorro(150000);

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
