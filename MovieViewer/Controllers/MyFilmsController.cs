using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieViewer.Data;
using MovieViewer.Data.Entities;

namespace MovieViewer.Controllers
{
    public class MyFilmsController : Controller
    {

        private FilmsDbContext context;
        public MyFilmsController(FilmsDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var filmsWithTags = context.Films
                .Include(f => f.Category)
                .ToList();
            return View(filmsWithTags);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var categories = new SelectList(context.Category.ToList(), nameof(Film.Id), nameof(Film.Name));
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Film model)
        {

            context.Films.Add(model);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var item = context.Films.Find(id);
            if (item == null) return NotFound();

            var categories = new SelectList(context.Category.ToList(), nameof(Film.Id), nameof(Film.Name));
            ViewBag.Categories = categories;

            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(Film model)
        {
            // TODO: add model validation

            context.Films.Update(model);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(int id)
        {
            var item = context.Films.Find(id);

            if (item == null) return NotFound();

            context.Films.Remove(item);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
