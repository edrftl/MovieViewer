//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Newtonsoft.Json.Linq;
//using MovieViewer.Models;
//using System.Diagnostics;

//namespace MovieViewer.Controllers
//{
//    public class HomeController : Controller
//    {
//        private const string API_KEY = "5eeb2897-61b9-461c-9224-d58251a9528a";

//        public async Task<IActionResult> Index()
//        {
//            var client = new HttpClient
//            {
//                Timeout = TimeSpan.FromSeconds(30)
//            };

//            // Отримання поточного року та місяця
//            var currentYear = DateTime.Now.Year;
//            var currentMonth = DateTime.Now.ToString("MMMM").ToUpper();  // Перетворення назви місяця на великі літери

//            var requestUri = $"https://kinopoiskapiunofficial.tech/api/v2.2/films/premieres?year={currentYear}&month={currentMonth}";

//            var request = new HttpRequestMessage
//            {
//                Method = HttpMethod.Get,
//                RequestUri = new Uri(requestUri),
//                Headers =
//        {
//            { "accept", "application/json" },
//            { "X-API-KEY", API_KEY },
//        },
//            };

//            try
//            {
//                using (var response = await client.SendAsync(request))
//                {
//                    response.EnsureSuccessStatusCode();
//                    var body = await response.Content.ReadAsStringAsync();
//                    var json = JObject.Parse(body);

//                    return View(json["films"]);
//                }
//            }
//            catch (HttpRequestException ex)
//            {
//                // Вивід діагностичного повідомлення про помилку
//                Debug.WriteLine($"Failed to retrieve data from the API: {ex.Message}");
//                throw;
//            }
//        }


//        public IActionResult Serials()
//        {
//            return View();
//        }

//        public IActionResult Cartoons()
//        {
//            return View();
//        }

//        public IActionResult Anime()
//        {
//            return View();
//        }

//        public IActionResult Top()
//        {
//            return View();
//        }

//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//}


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
using System.Globalization;

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
            var currentYear = DateTime.Now.Year;
            var currentMonth = DateTime.Now.ToString("MMMM", CultureInfo.InvariantCulture).ToUpper();
            var client = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(30)
            };
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://kinopoiskapiunofficial.tech/api/v2.2/films/premieres?year={currentYear}&month={currentMonth}"),
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

        public async Task<IActionResult> Serials()
        {
       
            
            var client = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(30)
            };
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://kinopoiskapiunofficial.tech/api/v2.2/films?order=RATING&type=TV_SERIES&ratingFrom=0&ratingTo=10&yearFrom=2022&yearTo=2024&page=1"),
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

        public async Task<IActionResult> Cartoons()
        {
            var client = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(30)
            };
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://kinopoiskapiunofficial.tech/api/v2.2/films?genres=18&order=RATING&type=ALL&ratingFrom=0&ratingTo=10&yearFrom=1950&yearTo=2024&page=1"),
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

        public async Task<IActionResult> Anime()
        {


            var client = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(30)
            };
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://kinopoiskapiunofficial.tech/api/v2.2/films?genres=24&order=RATING&type=ALL&ratingFrom=0&ratingTo=10&yearFrom=1950&yearTo=2024&page=1"),
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
