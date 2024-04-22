using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using MovieViewer.Extensions;
using MovieViewer.Data;
using MovieViewer.Data.Entities;
using AutoMapper;
using MovieViewer.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace MovieViewer.Controllers
{
    public class CartController : Controller
    {
        private readonly FilmsDbContext context;
        private readonly IMapper mapper;

        public CartController(FilmsDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var ids = HttpContext.Session.Get<List<int>>(WebConstants.CART_KEY);
            if (ids == null) ids = new List<int>();

            var entities = context.Films
                                    .Include(x => x.Category)
                                    .Where(x => ids.Contains(x.Id))
                                    .ToList();
            var list = mapper.Map<List<FilmCardModel>>(entities);

            return View(list);
        }

        public IActionResult Append(int id)
        {
            var ids = HttpContext.Session.Get<List<int>>(WebConstants.CART_KEY);

            if (ids == null) ids = new List<int>();



            ids.Add(id);
            HttpContext.Session.Set(WebConstants.CART_KEY, ids);

            return RedirectToAction("Index", "Home");
        }

        private const string API_KEY = "5eeb2897-61b9-461c-9224-d58251a9528a";
        public async Task<IActionResult> APIAppend(int kinopoiskId)
        {
            var client = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(30)
            };

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api.kinopoisk.dev/v1.4/movie/{kinopoiskId}"),
                Headers =
        {
            { "accept", "application/json" },
            { "X-API-KEY", API_KEY },
        },
            };

            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    var body = await response.Content.ReadAsStringAsync();
                    var film = JsonConvert.DeserializeObject<JObject>(body);

                    var ids = HttpContext.Session.Get<List<int>>(WebConstants.CART_KEY);

                    if (ids == null) ids = new List<int>();

                    // Додаємо новий елемент
                    ids.Add(kinopoiskId);

                    HttpContext.Session.Set(WebConstants.CART_KEY, ids);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    Console.WriteLine($"Failed to get film data: {response.StatusCode}");
                    Console.WriteLine($"Response content: {await response.Content.ReadAsStringAsync()}");
                    return RedirectToAction("Index", "Home"); 
                }
            }
        }




        public IActionResult Remove(int id)
        {
            // отримуємо дані з корзини
            var ids = HttpContext.Session.Get<List<int>>(WebConstants.CART_KEY);

            if (ids != null) ids.Remove(id);

            // зберігаємо новий список в корзині
            HttpContext.Session.Set(WebConstants.CART_KEY, ids);

            return RedirectToAction("Index");
        }

        public IActionResult Clear()
        {
            HttpContext.Session.Remove(WebConstants.CART_KEY);

            return RedirectToAction("Index");
        }
    }
}
