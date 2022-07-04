using CommerceApp.DbConnection;
using CommerceApp.Models;
using CommerceApp.Models.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using static CommerceApp.Models.trendyol;

namespace CommerceApp.Controllers
{
    public class ProductController : Controller
    {
        DataContext db = new DataContext();
        JavaScriptSerializer js = new JavaScriptSerializer();
        public IActionResult GetList()
        {
            return View(new AllLayoutModel
            {
                Products = db.Product.ToList()
            }) ;
        }
        //[HttpGet]
        //public IActionResult deneme()
        //{
        //    WebClient web = new WebClient();
        //    string data = web.DownloadString("https://api.trendyol.com/sapigw/product-categories/2265/attributes");
        //    var sd = js.Deserialize<Root>(data);
        //    List<CategoryAttribute> categoryAttributes = sd.categoryAttributes;
        //    for (int i = 1; i < categoryAttributes.Count; i++)
        //    {
        //        for (int k = 0; k < categoryAttributes[i].attributeValues.Count; k++)
        //        {
        //            if (categoryAttributes[i].attribute.name == "Boyut/Ebat")
        //            {
        //                break;
        //            }
        //            else
        //            {
        //                var atr = db.attributes.Where(x => x.name == categoryAttributes[i].attribute.name).FirstOrDefault();
        //                var entity = new AttributeValues
        //                {
        //                    Attributeid = 0,
        //                    categoryAttirbuteid = atr.id,
        //                    CreateDate = System.DateTime.Now,
        //                    isActive = true,
        //                    isDelete = false,
        //                    name = categoryAttributes[i].attributeValues[k].name,
        //                    ModifyDate = System.DateTime.Now,

        //                };
        //                db.Add(entity);
        //                db.SaveChanges();
        //            }

        //        }
        //    }
        //    return View();
        //}
        [HttpGet]
        public IActionResult Add(int id)
        {
            var materyal = db.attributeValues.Where(x => x.categoryAttirbuteid == 2).ToList();
            var beden = db.attributeValues.Where(x => x.categoryAttirbuteid == 4).ToList();
            var carsaftürü = db.attributeValues.Where(x => x.categoryAttirbuteid == 6).ToList();
            var renks = db.attributeValues.Where(x => x.categoryAttirbuteid == 1).ToList();
            var boyut = db.attributeValues.Where(x => x.categoryAttirbuteid == 3).ToList();
            List<SelectListItem> materyallist = new List<SelectListItem>();
            foreach (var item in materyal)
            {
                materyallist.Add(new SelectListItem { Text = item.name, Value = item.id.ToString() });
            }
            List<SelectListItem> bedenlist = new List<SelectListItem>();
            foreach (var asd in beden)
            {
                bedenlist.Add(new SelectListItem { Text = asd.name, Value = asd.id.ToString() });
            }
            List<SelectListItem> carsafturu = new List<SelectListItem>();
            foreach (var item in carsaftürü)
            {
                carsafturu.Add(new SelectListItem { Text = item.name, Value = item.id.ToString() });
            }
            List<SelectListItem> colors = new List<SelectListItem>();
            foreach (var item in renks)
            {
                colors.Add(new SelectListItem { Text = item.name, Value = item.id.ToString() });
            }
            List<SelectListItem> boyutebat = new List<SelectListItem>();
            foreach (var item in boyut)
            {
                boyutebat.Add(new SelectListItem { Text = item.name, Value = item.id.ToString() });
            }
            ViewBag.listmateryal = materyallist;
            ViewBag.listbeden = bedenlist;
            ViewBag.listcarsaf = carsafturu;
            ViewBag.listrenk = colors;
            ViewBag.listboyutebat = boyutebat;
            return View(new AllLayoutModel());
        }
        [HttpPost]
        public IActionResult Add(AllLayoutModel model, List<string> color, List<string> stok, List<string> ebat)
        {
            var categoryid = HttpContext.Request.RouteValues["id"];
            var productentity = new Product
            {
                ModifyDate = System.DateTime.Now,
                CreateDate = System.DateTime.Now,
                stock = model.product.stock,
                brand = model.product.brand,
                descriptions = model.product.descriptions,
                isActive = true,
                categoryid = Convert.ToInt32(categoryid),
                isDelete = false,
                modelcode = model.product.modelcode,
                name = model.product.name,
                price = model.product.price,
                reducedprice = model.product.reducedprice,
            };
            db.Add(productentity);
            db.SaveChanges();
            var lastaddproduct = db.Product.Where(x => x.isDelete == false).OrderByDescending(x => x.CreateDate).FirstOrDefault();
            for (int i = 1; 3 >= i; i++)
            {
                var entity = new ProductAttributeValue();
                entity.isActive = true;
                entity.isDelete = false;
                entity.ModifyDate = DateTime.Now;
                entity.name = "";
                entity.CreateDate = DateTime.Now;
                entity.productid = lastaddproduct.id;
                if (i == 1)
                    entity.varyantid = model.atttibutevaluesViewModel.materyalid; 
                else if (i == 2)
                    entity.varyantid = model.atttibutevaluesViewModel.carsaftype;
                else if (i == 3)
                    entity.varyantid = model.atttibutevaluesViewModel.bedenid;
                db.Add(entity);
                db.SaveChanges();
            }
            for (int i = 0; i < color.Count; i++)
            {
                string[] colorid = color[i].Split(',');
                var idcolor = colorid[1];
                var entity = new ProductAttributeValue
                {
                    name = colorid[0],
                    productid = lastaddproduct.id,
                    stock = Convert.ToInt32(stok[i]),
                    varyantid = Convert.ToInt32(ebat[i]),
                    CreateDate=DateTime.Now,
                    ModifyDate=DateTime.Now,
                    isActive=true,
                    isDelete=false
                };
                db.Add(entity);
                db.SaveChanges();
            }
            return View();
        }
    }
}