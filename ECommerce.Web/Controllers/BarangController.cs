using ECommerce.Repo;
using ECommerce.ViewModel;
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

            public ActionResult IndexCRUD()
            {
                  return View();
            }

            public ActionResult Create()
            {
                  List<VarianViewModel> varList = new List<VarianViewModel>() { new VarianViewModel() { Id = -1, Ukuran = "Pilih Ukuran" } };
                  varList.AddRange(VarianRepo.GetAll());
                  ViewBag.ListVarian = new SelectList(varList, "Id", "Ukuran");
                  return PartialView("_Create");
            }

            [HttpPost]
            public ActionResult Create(BarangViewModel model)
            {
                  if (ModelState.IsValid)
                  {
                        if (BarangRepo.Update(model))
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

            public ActionResult List()
            {
                  return PartialView("_List", BarangRepo.GetAll());
            }

            public ActionResult ListCRUD()
            {
                  return PartialView("_ListCRUD", BarangRepo.GetAll());
            }
            public ActionResult Display(int id)
            {
                  List<VarianViewModel> varList = new List<VarianViewModel>() { new VarianViewModel() { Id = -1, Ukuran = "Pilih Ukuran" } };
                  varList.AddRange(VarianRepo.GetAll());
                  ViewBag.ListVarian = new SelectList(varList, "Id", "Ukuran");
                  return PartialView("_Display", BarangRepo.GetByItemId(id));
            }

            public ActionResult Edit(int id)
            {
                  BarangViewModel model = BarangRepo.GetByItemId(id);

                  List<VarianViewModel> varList = new List<VarianViewModel>() { new VarianViewModel() { Id = -1, Ukuran = "Pilih Ukuran" } };
                  varList.AddRange(VarianRepo.GetAll());
                  ViewBag.ListVarian = new SelectList(varList, "Id", "Ukuran");
                  return PartialView("_Edit", model);
            }

            [HttpPost]
            public ActionResult Edit(BarangViewModel model)
            {
                  if (ModelState.IsValid)
                  {
                        if (BarangRepo.Update(model))
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
                  BarangViewModel model = BarangRepo.GetByItemId(id);
                  return PartialView("_Delete", model);
            }

            [HttpPost]
            public ActionResult DeleteConfirm(int id)
            {
                  if (BarangRepo.DeleteById(id))
                  {
                        return Json(new { success = true }, JsonRequestBehavior.AllowGet);
                  }
                  else
                  {
                        return Json(new { success = false, message = BarangRepo.Message }, JsonRequestBehavior.AllowGet);
                  }
            }

      }
}