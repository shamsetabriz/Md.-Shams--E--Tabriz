using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetOpenAuth.OpenId.Extensions.AttributeExchange;
using PartialViewPassingModel;
using PartialViewPassingModel.Models;

namespace PartialViewPassingModel.Controllers
{
    public class ProductController:Controller
    {
        ProductDbContext prodDb=new ProductDbContext();
        public ActionResult Index()
        {
            return View(prodDb.products.ToList());
            //var productList = new List<Product>()
            //{
            //    new Product() {Name = "Ice Cream", Price = 400},
            //    new Product() {Name = "Chicken fry", Price = 500},
            //    new Product() {Name = "Ghorar Dim", Price = 300},
            //};
            return View();
        }

        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create([Bind(Include ="Name,Price")]Product aProduct)
        {
            if (ModelState.IsValid)
            {
                prodDb.products.Add(aProduct);
                prodDb.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(aProduct);
        }
    }
}