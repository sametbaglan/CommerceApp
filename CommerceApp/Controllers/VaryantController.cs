using CommerceApp.DbConnection;
using CommerceApp.Models;
using CommerceApp.Models.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CommerceApp.Controllers
{
    public class VaryantController : Controller
    {
        DataContext db = new DataContext();
        public IActionResult List()
        {
            var attribute = db.attributes.ToList();
            return View(new AllLayoutModel
            {
                Listattributes = attribute
            });
        }
        [HttpGet]
        public IActionResult VaryantValues(int id)
        {
            var values = db.attributeValues.Where(x => x.categoryAttirbuteid == id).ToList();
            return View(new AllLayoutModel
            {
                ListattributeValues = values
            });
        }

        [HttpGet]
        public IActionResult AddValue(int id)
        {
            return View(new AllLayoutModel());
        }
        [HttpPost]
        public IActionResult AddValue(AllLayoutModel model)
        {

            var id = HttpContext.Request.RouteValues["id"];
            var attributevalue = new AttributeValues
            {
                name = model.attributeValue.name,
                categoryAttirbuteid = Convert.ToInt32(id),
                Attributeid = 0,
                CreateDate = DateTime.Now,
                isActive = true,
                isDelete = false,
                ModifyDate = DateTime.Now
            };
            db.Add(attributevalue);
            db.SaveChanges();
            return Redirect("/Varyant/AddValue/" + id);
        }
        [HttpGet]
        public IActionResult ProductByWithListAttirbute(int id)
        {
            ViewBag.productid = id;
            var listattribute = db.productAttributeValues.Where(x => x.productid == id).ToList();
            return View(new AllLayoutModel
            {
                productAttributeValues = listattribute
            });
        }
        [HttpPost]
        public List<AttributeValueViewModel> GetVariantByProdcutid(string id)
        {
            var listattributeviewmodel = new List<AttributeValueViewModel>();
            var attributesvalu = db.productAttributeValues.Where(x => x.productid == Convert.ToInt32(id)).ToList();
            foreach (var item in attributesvalu)
            {
                var value = db.attributeValues.Where(x => x.id == item.varyantid).FirstOrDefault();
                var attribut = db.attributes.FirstOrDefault(x => x.id == value.categoryAttirbuteid);
                var entity = new AttributeValueViewModel
                {
                    attribute = attribut.name,
                    attributevalue = value.name,
                    renk = item.name,
                    stock=item.stock
                };
                listattributeviewmodel.Add(entity);
            }
            return listattributeviewmodel;
        }
    }
}
