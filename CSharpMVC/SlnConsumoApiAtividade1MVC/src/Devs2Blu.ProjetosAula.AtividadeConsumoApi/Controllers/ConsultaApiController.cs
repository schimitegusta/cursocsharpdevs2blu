using Devs2Blu.ProjetosAula.AtividadeConsumoApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.AtividadeConsumoApi.Controllers
{
    public class ConsultaApiController : Controller
    {
        private readonly ValorantApiService Service = new ValorantApiService();

        public async Task<IActionResult> Agentes()
        {
            var result = await Service.GetAgents();
            return View(result);
        }

        public async Task<IActionResult> Armas()
        {
            var result = await Service.GetWeapons();
            return View(result);
        }

        public PartialViewResult Agents()
        {
            var result = Service.GetAgents();
            return PartialView();
        }

        public PartialViewResult Weapons()
        {
            var result = Service.GetWeapons();
            return PartialView();
        }
    }

}
