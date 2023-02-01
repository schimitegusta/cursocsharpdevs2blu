using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RevisaoProjetoNoticias.Domain.DTO;
using RevisaoProjetoNoticias.Domain.Entities;
using RevisaoProjetoNoticias.Domain.IServices;
using RevisaoProjetoNoticias.Infra.Data.Migrations;

namespace RevisaoProjetoNoticias.Web.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsService _service;
        private readonly ICategoryService _categoryService;
        public NewsController(INewsService service, ICategoryService categoryService)
        {
            _service = service;
            _categoryService = categoryService;
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
            ViewData["categoryId"] = new SelectList(_categoryService.FindAll(), "id", "name", "Select...");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("id, title, description, categoryId, createdOn, published")]NewsDTO news)
        {
            if (ModelState.IsValid)
            {
                if(await _service.Save(news) > 0)
                    return RedirectToAction(nameof(Index));
            }
            ViewData["categoryId"] = new SelectList(_categoryService.FindAll(), "id", "name", news.categoryId);
            return View(news);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var news = await _service.FindById(id);
            ViewData["categoryId"] = new SelectList(_categoryService.FindAll(), "id", "name", "Select...");
            return View(news);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("id, title, description, categoryId, createdOn, published")] NewsDTO news)
        {
            if (id != news.id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if (await _service.Save(news) > 0)
                    return RedirectToAction(nameof(Index));
            }
            ViewData["categoryId"] = new SelectList(_categoryService.FindAll(), "id", "name", "Select...");
            return View(news);
        }
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = await _service.FindById(id);
            ViewData["categoryId"] = new SelectList(_categoryService.FindAll(), "id", "name", "Select...");
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([Bind("id, title, description, categoryId, createdOn, published")] NewsDTO news)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Delete(news) != 0)
                    return RedirectToAction(nameof(Index));
            }
            ViewData["categoryId"] = new SelectList(_categoryService.FindAll(), "id", "name", "Select...");
            return View(news);
        }

        [HttpPost]
        public async Task<IActionResult> ImagePost([Bind("idNews")] ImageFieldNews newsModel)
        {
            var news = _service.FindById(newsModel.idNews);
        }
    }
}
