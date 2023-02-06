using Microsoft.AspNetCore.Mvc;
using ProjetoSaude.Domain.DTO;
using ProjetoSaude.Domain.IServices;

namespace ProjetoSaude.Web.Controllers
{
    public class PacientesController : Controller
    {
        private readonly IPacienteService _service;
        private readonly IPessoaService _servicePessoa;

        public PacientesController(IPacienteService service)
        {
            _service = service;
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
