using Introducao.Models;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            var pessoa = new Pessoa()
            {
                PessoaId = 1,
                Name = "Asael João",
                Tipo = "Administrador"
            };

            //Usando ViewData
            //ViewData["PessoaId"] = pessoa.PessoaId;
            //ViewData["Name"] = pessoa.Name;
            //ViewData["Tipo"] = pessoa.Tipo;

            //Usando viewbag
            //ViewBag.Id = pessoa.PessoaId;
            //ViewBag.Name = pessoa.Name;
            //ViewBag.Tipo = pessoa.Tipo;


            return View(pessoa);
        }
        public ActionResult Contatos()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Lista()
        {
            return View();
        }
    }
}