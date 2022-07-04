using CommerceApp.DbConnection;
using CommerceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CommerceApp.Controllers
{
    public class CategoriaController : Controller
    {
        DataContext db = new DataContext();
        [HttpGet]
        public IActionResult List()
        {
            var categoria = db.categories.Where(x=>x.parentId==null).ToList();
            return View(new AllLayoutModel
            {
                Categories = categoria
            });
        }
        [HttpGet]
        public IActionResult SubCategoria(int id)
        {
            var categorialist = db.categories.Where(x => x.parentId == id).ToList();
            return View(new AllLayoutModel
            {
                Categories = categorialist
            }) ;
        }
        [HttpGet]
        public IActionResult SubCategoriaAdd(int id)
        {
            return View(new AllLayoutModel());
        }
        [HttpPost]
        public IActionResult SubCategoriaAdd(AllLayoutModel model,int s)
        {
            
            var subcategoriaid= HttpContext.Request.RouteValues["id"];

            model.category.parentId = Convert.ToInt32(subcategoriaid);
            model.category.isActive = true;
            model.category.CreateDate = DateTime.Now;
            model.category.ModifyDate = DateTime.Now;

            db.Add(model.category);
            db.SaveChanges();
            return Redirect("/Categoria/SubCategoria/"+subcategoriaid);
        }
        [HttpGet]
        public IActionResult AddCategoria()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var categoria = db.categories.Where(x => x.parentId == null).ToList();
            foreach (var item in categoria)
            {
                selectListItems.Add(new SelectListItem
                {
                    Text = item.name,
                    Value = item.id.ToString()
                });
            }
            ViewBag.categoriesList = selectListItems;
            return View(new AllLayoutModel());
        }
        [HttpPost]
        public IActionResult AddCategoria(AllLayoutModel model)
        {
            if (model.category.id > 0)
            {
                model.category.parentId = model.category.id;
                model.category.id = 0;
            }
            else
                model.category.parentId = null;
            model.category.CreateDate = System.DateTime.Now;
            model.category.ModifyDate = System.DateTime.Now;
            model.category.isActive = true;
            model.category.isDelete = false;
            db.Add(model.category);
            db.SaveChanges();
            return RedirectToAction("List");
        }

    }
}
