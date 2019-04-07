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
            if(ModelState.IsValid)
                return View("Result", survey);
            else
                return View("Index");
        }
    }
}