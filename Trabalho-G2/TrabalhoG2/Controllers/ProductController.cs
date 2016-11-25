using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoG2.Models;

namespace TrabalhoG2.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository _productRepository = new ProductRepository();

        // GET: Product
        public ActionResult Index()
        {
            return View(_productRepository.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            _productRepository.Create(product);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _productRepository.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View(_productRepository.GetOne(id));
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            _productRepository.Update(product);
            return RedirectToAction("Index");
        }
    }
}