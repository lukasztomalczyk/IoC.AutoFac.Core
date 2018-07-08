using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IoC.AutoFacCore.Models;
using IoC.AutoFacCore.Services;

namespace IoC.AutoFacCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataBaseServices _dataBaseServices;

        public HomeController(IDataBaseServices dataBaseServices)
        {
            _dataBaseServices = dataBaseServices;
        }
        public IActionResult Index()
        {
            var result = _dataBaseServices.GetAll();
            return View(result);
        }
    }
}
