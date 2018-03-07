using ECommerce.DataModel;
using ECommerce.Repo;
using ECommerce.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Web.Controllers
{
      public class KeranjangController : Controller
      {
            // GET: Keranjang
            public ActionResult Index()
            {
                  return View();
            }

            public ActionResult GetByItemId(int id)
            {
                  return PartialView("_GetByItemId", KeranjangRepo.GetByItemId(id));
            }
      }
}