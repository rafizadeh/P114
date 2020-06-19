using lab19062020.DAL;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab19062020.Controllers
{
    public class HomeController : Controller
    {
        private readonly PagedDbContext _db = new PagedDbContext();

        // Custom Pagination Action
        //public ActionResult Index(int? page)
        //{
        //    ViewBag.PageSize = Math.Ceiling((decimal)_db.Products.Count() / 3);

        //    if (page == null)
        //    {
        //        ViewBag.Page = 0;
        //        return View(_db.Products.Take(3).ToList());
        //    }

        //    ViewBag.Page = page;

        //    return View(_db.Products.OrderBy(p=>p.Name).Skip((int)page *3).Take(3).ToList());
        //}

        // PagedList Pagination Action
        public ActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;

            var pageSize = 3;

            var onePageOfProducts = _db.Products.OrderBy(p=>p.Name).ToPagedList(pageNumber, pageSize);

            return View(onePageOfProducts);
        }
    }
}