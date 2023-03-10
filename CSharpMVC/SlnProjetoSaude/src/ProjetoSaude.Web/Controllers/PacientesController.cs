using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoSaude.Domain.DTO;
using ProjetoSaude.Domain.IServices;

namespace ProjetoSaude.Web.Controllers
{
    public class PacientesController : Controller
    {
        private readonly IPacienteService _service;
        private readonly IPessoaService _pessoaService;

        public PacientesController(IPacienteService service, IPessoaService pessoaService)
        {
            _service = service;
            _pessoaService = pessoaService;
        }

        public async Task<IActionResult> Index()
        {
            // To List all categories
            // Get of PacienteRepository through Dependecy Injection (PacienteService)
            var list = _service.FindAll();
            return View(list);
        }

        public JsonResult ListJson()
        {
            return Json(_service.FindAll());
        }

        public IActionResult Create()
        {
            ViewData["pessoaId"] = new SelectList(_pessoaService.FindAll(), "id", "nome", "Select...");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("id, tipoSanguineo, limitacao, alergia, pessoaId")] PacienteDTO paciente)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Save(paciente) > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(paciente);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var paciente = await _service.FindById(id);
            ViewData["pessoaId"] = new SelectList(_pessoaService.FindAll(), "id", "nome", "Select...");
            return View(paciente);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("id, tipoSanguineo, limitacao, alergia, pessoaId")] PacienteDTO paciente)
        {
            if (!(id == paciente.id))
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if (await _service.Save(paciente) > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(paciente);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var paciente = await _service.FindById(id);
            ViewData["pessoaId"] = new SelectList(_pessoaService.FindAll(), "id", "nome", "Select...");
            return View(paciente);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([Bind("id, tipoSanguineo, limitacao, alergia, pessoaId")] PacienteDTO paciente)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Delete(paciente.id) != 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(paciente.id);
        }
    }
}
