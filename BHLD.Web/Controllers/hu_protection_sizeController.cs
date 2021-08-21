using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BHLD.Data;
using BHLD.Model.Models;

namespace BHLD.Web.Controllers
{
    public class hu_protection_sizeController : Controller
    {
        private BHLDDbContext db = new BHLDDbContext();

        // GET: hu_protection_size
        public ActionResult Index()
        {
            return View();
        }

        // GET: hu_protection_size/Details/5

    }
}
