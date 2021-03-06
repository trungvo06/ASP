﻿using ShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1461467DAWEB.Areas.Admin.Controllers
{
    public class ProductTypeController : Controller
    {
        // GET: Admin/ProductType
        public ActionResult Index()
        {
            var resultProductType =  Models.ProductType.ListProductType();
            return View(resultProductType);
        }

        // GET: Admin/ProductType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ProductType/Create
        [HttpPost]
        public ActionResult Create(LoaiSanPham lsp)
        {
            try
            {
                _1461467DAWEB.Areas.Admin.Models.ProductType.insertProductType(lsp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/ProductType/Edit/5
        public ActionResult Edit(int id)
        {
            var resutlDetailsProductType = Models.ProductType.GetProductType(id);
            return View(resutlDetailsProductType);
        }

        // POST: Admin/ProductType/Edit/5
        [HttpPost]
        public ActionResult Edit(LoaiSanPham lsp)
        {
             
            Models.ProductType.UpdateProductType(lsp);
            return RedirectToAction("Index");
            
        }

         
        public ActionResult Delete(int id)
        {
            try
            {
                Models.ProductType.DeleteProductType(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
