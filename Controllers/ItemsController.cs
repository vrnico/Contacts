using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System.Collections.Generic;
using System;

namespace Project.Controllers
{
    public class ItemsController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Item> allItems = Item.GetAll();
            return View(allItems);
        }

        [HttpGet("/contacts/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/contacts/clear")]
        public ActionResult Clear()
        {
            Item.Clear();
            return View();
        }

        [HttpPost("/")]
        public ActionResult Create()
        {
            Item newItem = new Item(
            Request.Form["new-name"],
            Request.Form["new-address"],
            Convert.ToInt32(Request.Form["new-number"])
            );
            List<Item> allItems = Item.GetAll();
            return View("Index", allItems);
        }

        [HttpGet("/contacts/{id}")]
        public ActionResult Details(int id)
        {
            Item item = Item.Find(id);
            return View(item);
        }
    }
}
