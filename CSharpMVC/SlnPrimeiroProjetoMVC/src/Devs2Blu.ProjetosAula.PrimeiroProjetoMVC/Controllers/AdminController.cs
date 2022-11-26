using Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            List<User> users = new List<User>()
            {
                new User {Id = 1,Name = "Gustavo Soares", Login = "gustavoS"},
                new User {Id = 2,Name = "Gustavo Schimite", Login = "gustavoSchi"},
                new User {Id = 3,Name = "Patrick Weber", Login = "patrickW"},
                new User {Id = 4,Name = "Camarada Schimia", Login = "camaradaS"},
                new User {Id = 5,Name = "Gustavo", Login = "gustava1"}
            };
            return View(users);
        }
        public IActionResult Indicadores()
        {
            return View();
        }

        [Route("cards")]
        public PartialViewResult CardsResultados()
        {
            //var result = ServiceCollection.GetLista();
            return PartialView();
        }
    }
}
