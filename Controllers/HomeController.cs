using System;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
// using DbConnection;
using quotingDojo2.Models;
using Microsoft.EntityFrameworkCore;

namespace quotingDojo2.Controllers
{
    public class HomeController : Controller
    {
        private QuoteContext _context;
        public HomeController(QuoteContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<Quote> allQuotes = _context.quotes.ToList();
            ViewBag.Quotes = allQuotes;
            return View();
        }

        [HttpGet]
        [Route("/quote/{id}")]
        public IActionResult QuoteDisplay(int id)
        {
            return View();
        } 
    }

    // Session:
    // HttpContext.Session.SetString("KeyName", "Value");
    // string sessionStr = HttpContext.Session.GetString("KeyName");

    // HttpContext.Session.SetInt32("KeyName", Int);
    // int? sessionInt = HttpContext.Session.GetInt32("KeyName");

    // JSON:
    // session.SetString(key, JsonConvert.SerializeObject(value);
    // string jsonValue = session.GetString(key)
    // JsonConvert.DeserializeObject<T>(value);
}
