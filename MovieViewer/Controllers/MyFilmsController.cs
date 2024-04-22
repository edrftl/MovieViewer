using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieViewer.Data;
using MovieViewer.Data.Entities;
using MovieViewer.Models;

namespace MovieViewer.Controllers
{
    [Authorize(Roles=Roles.ADMIN)]
    public class MyFilmsController : Controller
    {

        private FilmsDbContext context;
        private readonly IMapper mapper;

        public MyFilmsController(FilmsDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var filmsWithTags = context.Films
                .Include(f => f.Category)
                .ToList();

            LoadCategories();

            return View(filmsWithTags);
        }

        public IActionResult Filter(int? categoryId)
        {
            if (categoryId == null)
                return RedirectToAction("Index");

            var films = context.Films
                            .Include(x => x.Category)
                            .Where(x => x.CategoryId == categoryId)
                            .ToList();

            LoadCategories();
            return View("Index", films);
        }


        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Creation = true;
            LoadCategories();

            return View("Upsert");
        }

        [HttpPost]
        public IActionResult Create(FilmModel model)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                ViewBag.Creation = true;  // Очистіть ViewBag перед повторним відображенням
                return View("Upsert", model);
            }

            var entity = mapper.Map<Film>(model);

            context.Films.Add(entity);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Edit(int id)
        {
            var item = context.Films.Find(id);
            if (item == null) return NotFound();

            ViewBag.Creation = false;   
            LoadCategories();

            var model = mapper.Map<FilmModel>(item);

            return View("Upsert", model);
        }

        [HttpPost]
        public IActionResult Edit(FilmModel model)
        {

            if (!ModelState.IsValid)
            {
                LoadCategories();
                ViewBag.Creation = false;
                return View("Upsert", model);
            }

            var entity = mapper.Map<Film>(model);

            context.Films.Update(entity);
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

        private void LoadCategories()
        {
            var categories = new SelectList(context.Category.ToList(), nameof(Film.Id), nameof(Film.Name));
            ViewBag.Categories = categories;
        }
    }
}
