using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FichaOnline.Controllers
{
    public class FichaCatOpcRespController : Controller
    {
        // GET: FichaCatOpcRespController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FichaCatOpcRespController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FichaCatOpcRespController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FichaCatOpcRespController/Create
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

        // GET: FichaCatOpcRespController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FichaCatOpcRespController/Edit/5
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

        // GET: FichaCatOpcRespController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FichaCatOpcRespController/Delete/5
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
