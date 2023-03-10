using Microsoft.AspNetCore.Mvc;
using ProjetoSaude.Domain.DTO;
using ProjetoSaude.Domain.IServices;

namespace ProjetoSaude.Web.Controllers
{
    public class ProntuariosController : Controller
    {
        private readonly IProntuarioService _service;

        public ProntuariosController(IProntuarioService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            // To List all categories
            // Get of ProntuarioRepository through Dependecy Injection (ProntuarioService)
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
        public async Task<IActionResult> Create([Bind("id, dataAbertura, pacienteId")] ProntuarioDTO prontuario)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Save(prontuario) > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(prontuario);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var prontuario = await _service.FindById(id);
            return View(prontuario);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("id, dataAbertura, pacienteId")] ProntuarioDTO prontuario)
        {
            if (!(id == prontuario.id))
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if (await _service.Save(prontuario) > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(prontuario);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var prontuario = await _service.FindById(id);
            return View(prontuario);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([Bind("id, dataAbertura, pacienteId")] ProntuarioDTO prontuario)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Delete(prontuario.id) != 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(prontuario.id);
        }
    }
}
