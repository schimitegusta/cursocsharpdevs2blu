using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RevisaoProjetoNoticias.Application.Service.SQLServerServices;
using RevisaoProjetoNoticias.Domain.DTO;
using RevisaoProjetoNoticias.Domain.IServices;
using System.Runtime.CompilerServices;

namespace RevisaoProjetoNoticias.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            return View(_service.FindAll());
        }

        public IActionResult Add()
        { 
            return View();
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
        public async Task<IActionResult> Create([Bind("id, name")] CategoryDTO category)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Save(category) > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = await _service.FindById(id);
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("id, name")] CategoryDTO category)
        {
            if (id != category.id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if (await _service.Save(category) > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = await _service.FindById(id);
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([Bind("id, name")] CategoryDTO category)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Delete(category) != 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
    }
}
