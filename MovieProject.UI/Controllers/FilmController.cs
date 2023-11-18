using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieProject.Entity.Entities;
using MovieProject.UI.DTOs.Films;
using Newtonsoft.Json;
using System.Text;

namespace MovieProject.UI.Controllers
{
    public class FilmController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public FilmController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7096/api/Film");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var hospitals = JsonConvert.DeserializeObject<List<ResultFilmDto>>(jsonData);

                return View(hospitals);
            }

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var client = _httpClientFactory.CreateClient();

            // Kategorileri ve aktörleri al
            var categoryResponse = await client.GetAsync("https://localhost:7096/api/Category");
            //var actorResponse = await client.GetAsync("https://localhost:7096/api/Actor");

            if (categoryResponse.IsSuccessStatusCode)
            {
                var categoryJson = await categoryResponse.Content.ReadAsStringAsync();
               // var actorJson = await actorResponse.Content.ReadAsStringAsync();

                var categories = JsonConvert.DeserializeObject<List<Category>>(categoryJson);
                //var actors = JsonConvert.DeserializeObject<List<Actor>>(actorJson);

                var viewModel = new FilmAddDto
                {
                    Categories = categories,
                   
                };
                return View(viewModel);
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(FilmAddDto createhospitalDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createhospitalDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7096/api/Film/CreateFilm", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7123/api/Hospital/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<FilmUpdateDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(FilmUpdateDto hospitalUpdateDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(hospitalUpdateDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7123/api/Hospital/UpdateHospital/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7123/api/Hospital/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
