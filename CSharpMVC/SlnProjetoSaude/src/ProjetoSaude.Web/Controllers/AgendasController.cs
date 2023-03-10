using Microsoft.AspNetCore.Mvc;
using ProjetoSaude.Domain.DTO;
using ProjetoSaude.Domain.IServices;

namespace ProjetoSaude.Web.Controllers
{
    public class AgendasController : Controller
    {
        private readonly IAgendaService _service;

        public AgendasController(IAgendaService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            // To List all categories
            // Get of AgendaRepository through Dependecy Injection (AgendaService)
            var list = _service.FindAll();
            return View(list);
        }

        public JsonResult ListJson()
        {
            return Json(_service.FindAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("id, titulo, descricao, dataConsulta, pacienteId")] AgendaDTO agenda)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Save(agenda) > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(agenda);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var agenda = await _service.FindById(id);
            return View(agenda);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("id, titulo, descricao, dataConsulta, pacienteId")] AgendaDTO agenda)
        {
            if (!(id == agenda.id))
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if (await _service.Save(agenda) > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(agenda);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var agenda = await _service.FindById(id);
            return View(agenda);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([Bind("id, titulo, descricao, dataConsulta, pacienteId")] AgendaDTO agenda)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Delete(agenda.id) != 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(agenda.id);
        }
    }
}
