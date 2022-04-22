using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Parcial.Controllers
{
    public class ConsultController : Controller
    {
        // GET: ConsultController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ConsultController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConsultController/Create
        public ActionResult Create()
        {
            return View();
        }


        // GET: ConsultController/Create
        public ActionResult Consult()
        {
            return View();
        }
        // POST: ConsultController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConsultController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConsultController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConsultController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConsultController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
