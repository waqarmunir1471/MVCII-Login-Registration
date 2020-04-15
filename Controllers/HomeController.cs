using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCII_Login_Registration.Models;

namespace MVCII_Login_Registration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("Registration")]
        public IActionResult Registration(Registration registration){
            if(ModelState.IsValid){
                return View("SuccessReg");
            }else{
                return View("Index");
            }
        }
        [HttpPost("Login")]
        public IActionResult Login(Login login){
            if(ModelState.IsValid){
                return View("SuccessReg");
            }else{
                return View("Index");
            }
        }
        public IActionResult Privacy()
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
