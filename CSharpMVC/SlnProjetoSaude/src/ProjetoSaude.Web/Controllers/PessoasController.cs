using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoSaude.Domain.DTO;
using ProjetoSaude.Domain.IServices;
using ProjetoSaude.Web.Models;
using System.Dynamic;

namespace ProjetoSaude.Web.Controllers
{
    public class PessoasController : Controller
    {
        private readonly IPessoaService _service;

        public PessoasController(IPessoaService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            // To List all categories
            // Get of PessoaRepository through Dependecy Injection (PessoaService)
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
        public async Task<IActionResult> Create([Bind("id, nome, dataNasc, sexo, telefone, email, enderecoId")] PessoaDTO pessoa)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Save(pessoa) > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var pessoa = await _service.FindById(id);
            return View(pessoa);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("id, nome, dataNasc, sexo, telefone, email, enderecoId")] PessoaDTO pessoa)
        {
            if (!(id == pessoa.id))
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if (await _service.Save(pessoa) > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var pessoa = await _service.FindById(id);
            return View(pessoa);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([Bind("id, nome, dataNasc, sexo, telefone, email, enderecoId")] PessoaDTO pessoa)
        {
            if (ModelState.IsValid)
            { 
                if (await _service.Delete(pessoa.id) != 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(pessoa.id);
        }
    }
}
