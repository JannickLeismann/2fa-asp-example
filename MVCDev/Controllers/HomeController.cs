using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCDev.Data;
using MVCDev.Models;
using System.Diagnostics;

namespace MVCDev.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public ActionResult Index()
        {            
            return View();
        }


    }
}
