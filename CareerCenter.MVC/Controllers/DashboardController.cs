using AutoMapper;
using CareerCenter.Core.Contexts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerCenter.MVC.Controllers
{
    public class DashboardController:DashboardBaseController
    {
        public DashboardController(CareerCenterDbContext context, IMapper mapper, IWebHostEnvironment hostEnvironment)
            : base(context, mapper, hostEnvironment)
        { }
        public ActionResult HeaderUser()
        {

            ViewBag.User = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault();
            return PartialView("~/Views/Shared/_HeaderUser.cshtml");
        }
    }
}
