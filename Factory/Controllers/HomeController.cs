using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Factory.Models;
namespace Factory.Controllers
{
    public class HomeController : Controller
    {

     private readonly FactoryContext _db;

      public HomeController(FactoryContext db)
      {
        _db = db;
      }


      [HttpGet("/")]
      public ActionResult Index()
      {
        //get list of both models in db, viewbag use in html file.
        var engineerList = _db.Engineers.ToList();
        var machineList = _db.Machines.ToList();
        ViewBag.EngineerList = engineerList;
        ViewBag.MachineList = machineList;
      return View();
      }

    }
}