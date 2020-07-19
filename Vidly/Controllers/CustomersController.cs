﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        private ApplicationUser.ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationUser.ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var customers = _context.Customers;
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            else
                return View(customer);
        }
        public IEnumerable<Customer> getCustomers()
        {
            return new List<Customer> (){
                new Customer { Name = "Julie Adams", Id = 1},
                new Customer { Name = "Jhon Doe", Id = 2},
                new Customer { Name = "Hassan Siddiqui", Id = 3}
            };
        }
    }
}