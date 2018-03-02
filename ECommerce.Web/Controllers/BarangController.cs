using ECommerce.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Web.Controllers
{
      public class BarangController : Controller
      {
            // GET: Barang
            public ActionResult Index()
            {
                  return View();
            }

            public ActionResult List()
            {
                  return PartialView("_List", BarangRepo.GetAll());
            }
      }
}