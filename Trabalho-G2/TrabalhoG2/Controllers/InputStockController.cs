using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoG2.Models;

namespace TrabalhoG2.Controllers
{
    public class InputStockController : Controller
    {

        InputStockRepository _inputStockReposity = new InputStockRepository();
        InputStockProductRepository _inputStockProductRepository = new InputStockProductRepository();
        ProductRepository _productRepository = new ProductRepository();

        // GET: InputStock
        public ActionResult Index()
        {
            return View(_inputStockReposity.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(InputStock inputStock)
        {
            _inputStockReposity.Create(inputStock);
            return RedirectToAction("Index");
        
        }

        public ActionResult Details(int id)
        {
            ViewBag.inputStockProduct = _inputStockProductRepository.GetInputStockProduct(id);
            ViewBag.product = _productRepository.GetAll();

            return View(_inputStockReposity.GetOne(id));
        }

        [HttpPost]
        public ActionResult CreateStockProduct(InputStockProduct inputStockProduct)
        {
            _inputStockProductRepository.Create(inputStockProduct);
            return Redirect(Request.UrlReferrer.ToString());
        }

        public ActionResult Delete(int id)
        {
            _inputStockProductRepository.Delete(id);
            _inputStockReposity.Delete(id);

            return RedirectToAction("Index");
        }

        public ActionResult DeleteOne(int id)
        {
            _inputStockProductRepository.DeleteOne(id);
            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}