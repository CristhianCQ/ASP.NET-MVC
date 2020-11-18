﻿using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class RestaurantsController : Controller
    {
        IRestaurantData db;

        public RestaurantsController(IRestaurantData db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            var model = db.GetAll();

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            return View(model);
        }
    }
}