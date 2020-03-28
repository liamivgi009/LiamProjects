﻿using AmiamStore.Controllers.BaseControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmiamStore.App_DAL;
using System.Data;
using AmiamStore.Models;

namespace AmiamStore.Controllers
{
    public class ShareController : BaseController
    {
        public ShareController() : base(false) { }
        // GET: Share
        [HttpGet]
        public ActionResult MasterPage()
        { 
            return View();
        }
       [HttpPost]
        public ActionResult MasterPage(string ProductSerch)
        {
            MasterDAL c = new MasterDAL();
            List<ProductModel> ProductSerchResult = ConvertDataTableToList(ProductSerch);
            ViewBag.Message = ProductSerchResult;
            return View();
        }
        public List<ProductModel> ConvertDataTableToList(string ProductSerch)
        {
            MasterDAL c = new MasterDAL();
            DataTable dt = c.GetProductByName(ProductSerch);
            List<ProductModel> productsSerch = new List<ProductModel>();
            foreach (DataRow dr in dt.Rows)
            {
                ProductModel product = new ProductModel();
                product.ProductID = (int)dr["ProductID"];
                product.ProductName = dr["ProductName"].ToString();
                product.ProductImage = dr["ProductImage"].ToString();
                product.ProductPrice = (int)dr["ProductPrice"];
                product.ProductDescription = dr["ProductDescription"].ToString();
                product.CatagoryName = dr["CatagoryName"].ToString();
                productsSerch.Add(product);
            }
            return productsSerch;
        }
        public ActionResult SerchTable()
        {
            return View();
        }
    }
}