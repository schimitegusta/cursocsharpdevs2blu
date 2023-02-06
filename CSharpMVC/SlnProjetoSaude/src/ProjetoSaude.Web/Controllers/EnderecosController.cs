using Microsoft.AspNetCore.Mvc;
using ProjetoSaude.Domain.DTO;
using ProjetoSaude.Domain.IServices;

namespace ProjetoSaude.Web.Controllers
{
    public class EnderecosController : Controller
    {
        private readonly IEnderecoService _service;

        public EnderecosController(IEnderecoService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            // To List all categories
            // Get of EnderecoRepository through Dependecy Injection (EnderecoService)
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
        public async Task<IActionResult> Create([Bind("id, rua, numero, cep, regiao, cidade, estado")] EnderecoDTO endereco)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Save(endereco) > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(endereco);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var endereco = await _service.FindById(id);
            return View(endereco);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("id, rua, numero, cep, regiao, cidade, estado")] EnderecoDTO endereco)
        {
            if (!(id == endereco.id))
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if (await _service.Save(endereco) > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(endereco);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var endereco = await _service.FindById(id);
            return View(endereco);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([Bind("id, rua, numero, cep, regiao, cidade, estado")] EnderecoDTO endereco)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Delete(endereco.id) != 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(endereco.id);
        }
    }
}
