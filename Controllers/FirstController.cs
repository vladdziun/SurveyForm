using Microsoft.AspNetCore.Mvc;
using System;
using FirstProject.Models;

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
        public IActionResult Result(Survey survey)
        {
            return View("Result", survey);
        }
    }
}