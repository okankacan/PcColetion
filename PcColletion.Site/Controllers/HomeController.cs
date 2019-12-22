using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PcColletion.InfraStructure.httpClient;
using PcColletion.InfraStructure.Model;
using PcColletion.Site.Models;

namespace PcColletion.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
 
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
         }

        public async Task<IActionResult> Index()
        {
            var apiUrl = _configuration.GetSection("ApiUrl").Value + "values";
             var response = await  HttpRequestFactory.Get(apiUrl);
              var model = response.ContentAsType<List<Item>>();
            ViewBag.Processor = model.Where(c => c.CategoryId == 1);
            ViewBag.Ram = model.Where(c => c.CategoryId == 2);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetPrice(int Id)
        {
            var apiUrl = _configuration.GetSection("ApiUrl").Value + "values/"+ Id;
            var response = await HttpRequestFactory.Get(apiUrl);
            var model = response.ContentAsType<Item>();

            return Ok(model.Price);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
