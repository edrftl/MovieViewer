using Microsoft.AspNetCore.Mvc;
using MovieViewer.Data;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MovieViewer.Models;
using System.Diagnostics;
using MovieViewer.Data.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MovieViewer.Controllers
{

   
    public class HomeController : Controller
    {
        private const string API_KEY = "5eeb2897-61b9-461c-9224-d58251a9528a";
        public HomeController()
        {
        }
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(30)
            };
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://kinopoiskapiunofficial.tech/api/v2.2/films/collections?type=TOP_POPULAR_ALL&page=1"),
                Headers =
                {
                    { "accept", "application/json" },
                    { "X-API-KEY", API_KEY },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<JObject>(body);


                return View(json["items"]);
            }
        }








        public IActionResult Serials()
        {
            return View();
        }

        public IActionResult Cartoons()
        {
            return View();
        }

        public IActionResult Anime()
        {
            return View();
        }   
        public IActionResult Top()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
