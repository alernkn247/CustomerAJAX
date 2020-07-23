using CustomerAJAX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerAJAX.Controllers
{
    public class CustomerController : Controller
    {

        Customer customer;
        List<Customer> customers;

        public CustomerController()
        {
            customers = new List<Customer>()
            {
                new Customer(0,"Jay",12),
                new Customer(1,"Alen",25),
                new Customer(2,"Mathew",22),
                new Customer(3,"George",24),
                new Customer(4,"Hilton",13),
                new Customer(5,"Hilary",16),
                
            };
        }
        // GET: Customer
        public ActionResult Index()
        {
            Tuple<List<Customer>, Customer> tuple;
            tuple = new Tuple<List<Customer>, Customer>(customers, customers[0]);
            
            return View("Customer",tuple);
        }
        [HttpPost]
        public ActionResult OnSelectCustomer(string CustomerNumber)
        {
            Tuple<List<Customer>, Customer> tuple;
            tuple = new Tuple<List<Customer>, Customer>(customers, customers[int.Parse(CustomerNumber)]);

            return View("Customer", tuple);
        }
    }
}