using Microsoft.AspNetCore.Mvc;
using System;

namespace FirstProject.Controllers 
{
    public class FirstController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpPost("result")]
        public IActionResult Result(string name, string location, string language, string comment)
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comment = comment;
            return View("Result");
        }
    }
}