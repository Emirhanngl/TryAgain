using Business.Concrete.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Moq;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //ProductManager productManager = new ProductManager(new EfProductDal());
        public ActionResult Index()
        {
            return View//(productManager.GetAll());   
        }
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult List()
        {
            return View();
        }
    }
}