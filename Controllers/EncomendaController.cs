using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pingou.Models;
using Pingou.Repositorio;
using Refit;

namespace Pingou.Controllers
{
    public class EncomendaController : Controller
    {
        private EncomendaModel _encomenda = new EncomendaModel();
        private PacoteModel _pacote = new PacoteModel();

        string[] erroMessage = new string[]{
            "401"
        };

        public IActionResult Index()
        {
            return View(_pacote);
        }

        [HttpPost]
        public async Task<IActionResult> Index(EncomendaModel encomenda)
        {
            
            try
            {
                _encomenda = encomenda;
                var packageClient = RestService.For<IEncomendaRepositorio>("https://api.linketrack.com");
                _pacote = await packageClient.GetPackageAsync(_encomenda.Codigo.ToUpper());
                return View(_pacote);
            }
            catch (System.Exception ex)
            {
                if (ex.Message.Contains(erroMessage[0]))
                {
                    return RedirectToAction("Erro401", "Error");
                }
                return Content("sfs");
            }
        }

    }
}