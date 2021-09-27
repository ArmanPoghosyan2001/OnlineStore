using BL;
using Microsoft.AspNetCore.Mvc;
using Models;
using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    public class PhoneController : Controller
    {
        PhoneBL phoneBl;

        public PhoneController(MobileContext context)
        {
            phoneBl = new PhoneBL(context);
        }
        [HttpGet]
        public IActionResult Index()
        {
            PhoneViewModel phonesVM = new PhoneViewModel();
            phonesVM.phones = phoneBl.GetAll();
            return View(phonesVM);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Phone phone)
        {
            phoneBl.Create(phone);
            return RedirectToAction("Create");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            Phone phone = phoneBl.GetDetails(id);
            return View(phone);
        }

    }
}
