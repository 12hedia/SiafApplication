using Microsoft.AspNetCore.Mvc;
using SiafManagementStudio.Models;
using SiafManagementStudio.Repository;

namespace SiafManagementStudio.Controllers
{
    public class DepartementController : Controller
    {
        private readonly IDepartementRepository departement;
        public DepartementController(IDepartementRepository Dep)
        {
            this.departement = Dep;
        }



        // GET: DepartementController
        public ActionResult Index()
        {
            return View(departement.getAll());
        }

        // GET: DepartementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DepartementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DepartementTable collection)
        {
            departement.ajouter(collection);
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartementController/Edit/5
        public ActionResult Edit(int id)
        {
            DepartementTable t1 = departement.getbyId(id);
            return View(t1);
        }

        // POST: DepartementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, DepartementTable collection)
        {
            try
            {
                departement.update(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DepartementController/Delete/5
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
