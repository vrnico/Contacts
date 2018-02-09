using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System.Collections.Generic;
using System;

namespace Project.Controllers
{
    public class ContactsController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Contact> allContacts = Contact.GetAll();
            return View(allContacts);
        }

        [HttpGet("/contacts/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/contacts/clear")]
        public ActionResult Clear()
        {
            Contact.Clear();
            return View();
        }

        [HttpPost("/")]
        public ActionResult Create()
        {
            Contact newContact = new Contact(
            Request.Form["new-name"],
            Request.Form["new-address"],
            Request.Form["new-number"]
            );
            newContact.Save();
            List<Contact> allContacts = Contact.GetAll();
            return View("Index", allContacts);
        }

        [HttpGet("/contacts/{id}")]
        public ActionResult Details(int id)
        {
            Contact contact = Contact.Find(id);
            return View(contact);
        }
    }
}
