using ECommerce.Repo;
using ECommerce.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Web.Controllers
{
      public class VarianController : Controller
      {
            // GET: Varian
            public ActionResult Index()
            {
                  return View();
            }

            public ActionResult List()
            {
                  return PartialView("_List", VarianRepo.GetAll());
            }

            public ActionResult Create()
            {
                  return PartialView("_Create");
            }

            [HttpPost]
            public ActionResult Create(VarianViewModel model)
            {
                  if (ModelState.IsValid)
                  {
                        if (VarianRepo.Update(model))
                        {
                              return Json(new { success = true }, JsonRequestBehavior.AllowGet);
                        }
                        else
                        {
                              return Json(new { success = false, message = VarianRepo.Message }, JsonRequestBehavior.AllowGet);
                        }
                  }

                  return Json(new { success = false, message = "Error invalid" }, JsonRequestBehavior.AllowGet);
            }

            public ActionResult Edit(int id)
            {
                  VarianViewModel model = VarianRepo.GetByItemId(id);

                  return PartialView("_Edit", model);
            }

            [HttpPost]
            public ActionResult Edit(VarianViewModel model)
            {
                  if (ModelState.IsValid)
                  {
                        if (VarianRepo.Update(model))
                        {
                              return Json(new { success = true }, JsonRequestBehavior.AllowGet);
                        }
                        else
                        {
                              return Json(new { success = false, message = BarangRepo.Message }, JsonRequestBehavior.AllowGet);
                        }
                  }

                  return Json(new { success = false, message = "Error invalid" }, JsonRequestBehavior.AllowGet);
            }

            public ActionResult Delete(int id)
            {
                  VarianViewModel model = VarianRepo.GetByItemId(id);
                  return PartialView("_Delete", model);
            }

            [HttpPost]
            public ActionResult DeleteConfirm(int id)
            {
                  if (VarianRepo.DeleteById(id))
                  {
                        return Json(new { success = true }, JsonRequestBehavior.AllowGet);
                  }
                  else
                  {
                        return Json(new { success = false, message = VarianRepo.Message }, JsonRequestBehavior.AllowGet);
                  }
            }
      }
}