using _1___Application.Models;
using _2___Services;
using _4___Domain;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Diagnostics;

namespace _1___Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public GetData getData = new GetData();
        public Crud crud = new Crud();

        public ReturnApiCEPModel Return { get; private set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            string cepDigitado = Request.Form["cepValor"];

            var result = getData.ApiCEPGet(cepDigitado);
            
            ViewBag.cep = result.cep;
            ViewBag.logradouro = result.logradouro;
            ViewBag.complemento = result.complemento;
            ViewBag.bairro = result.bairro;
            ViewBag.localidade = result.localidade;
            ViewBag.uf = result.uf;
            ViewBag.ibge = result.ibge;
            ViewBag.gia = result.gia;
            ViewBag.ddd = result.ddd;
            ViewBag.siafi = result.siafi;

            var resultbanco = crud.allData(cepDigitado);

            ViewBag.cep1 = resultbanco.FirstOrDefault().cep;
            ViewBag.logradouro1 = resultbanco.FirstOrDefault().logradouro;
            ViewBag.complemento1 = resultbanco.FirstOrDefault().complemento;
            ViewBag.bairro1 = resultbanco.FirstOrDefault().bairro;
            ViewBag.localidade1 = resultbanco.FirstOrDefault().localidade;
            ViewBag.uf1 = resultbanco.FirstOrDefault().uf;
            ViewBag.ibge1 = resultbanco.FirstOrDefault().ibge;
            ViewBag.gia1 = resultbanco.FirstOrDefault().gia;
            ViewBag.ddd1 = resultbanco.FirstOrDefault().ddd;
            ViewBag.siafi1 = resultbanco.FirstOrDefault().siafi;
            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}