using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoG2.Models;

namespace TrabalhoG2.Controllers
{
    public class OutputStockController : Controller
    {
        OutputStockRepository _outputStockRepository = new OutputStockRepository();
        OuputStockProductRepository _outputStockProductRepositry = new OuputStockProductRepository();
        ProductRepository _productRepository = new ProductRepository();

        // GET: OutputStock
        public ActionResult Index()
        {
            return View(_outputStockRepository.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(OutputStock outputStock)
        {
            _outputStockRepository.Create(outputStock);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            ViewBag.outputStockProduct = _outputStockProductRepositry.GetOutputStockProduct(id);
            ViewBag.product = _productRepository.GetAll();
            return View(_outputStockRepository.GetOne(id));
        }

        [HttpPost]
        public ActionResult CreateStockProduct(OutputStockProduct outputStockProduct)
        {
            _outputStockProductRepositry.Create(outputStockProduct);
            return Redirect(Request.UrlReferrer.ToString());
        }

        public ActionResult Delete(int id)
        {
            _outputStockProductRepositry.Delete(id);
            _outputStockRepository.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteOne(int id)
        {
            _outputStockProductRepositry.DeleteOne(id);
            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}