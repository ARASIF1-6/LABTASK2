using LabTask2.Models;
using LabTask2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTask2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult LooslyType()
        {
            var product1 = new Product()
            {
                id = 1,
                name = "Bombay",
                price = 20,
                quantity = 20,
                category = "Chips",
                production_date = "22-10-2024",
                is_disposeable = false,
                helpline = "01445678999",
                support_mail = "kjh@gmail.com"
            };

            var product2 = new Product()
            {
                id = 2,
                name = "Maridian",
                price = 20,
                quantity = 20,
                category = "Chips",
                production_date = "22-10-2024",
                is_disposeable = false,
                helpline = "01445678999",
                support_mail = "kjh@gmail.com"
            };

            var viewModel = new SampleViewModel()
            {
                Products = new List<Product> { product1, product2 }
            };
            return View(viewModel);
        }

        public ActionResult StronglyType()
        {
            var product1 = new Product()
            {
                id = 1,
                name = "Bombay",
                price = 20,
                quantity = 20,
                category = "Chips",
                production_date = "22-10-2024",
                is_disposeable = false,
                helpline = "01445678999",
                support_mail = "kjh@gmail.com"
            };

         /*   var product2 = new Product()
            {
                id = 2,
                name = "Maridian",
                price = 20,
                quantity = 20,
                category = "Chips",
                production_date = "22-10-2024",
                is_disposeable = false,
                helpline = "01445678999",
                support_mail = "kjh@gmail.com"
            };

            var viewModel = new SampleViewModel()
            {
                Products = new List<Product> { product1, product2 }
            };*/
            return View(product1);
        }

        public ActionResult TemplateType()
        {
            var product1 = new Product()
            {
                id = 1,
                name = "Bombay",
                price = 20,
                quantity = 20,
                category = "Chips",
                production_date = "22-10-2024",
                is_disposeable = false,
                helpline = "01445678999",
                support_mail = "kjh@gmail.com"
            };
            return View(product1);
        }
    }
}