using Microsoft.AspNetCore.Mvc;
using SiafManagementStudio.Models;
using SiafManagementStudio.Repository;

namespace SiafManagementStudio.Controllers
{
    public class PersonnelController : Controller
    {
        private readonly IPersonnelRepository personnel;
        private readonly IDepartementRepository departement;
        public PersonnelController(IPersonnelRepository pr, IDepartementRepository dep)
        {
            this.personnel = pr;
            this.departement = dep;
        }
        // GET: PersonnelController
        public ActionResult Index()
        {
            List<PersonnelTable> prs = personnel.getAll();
            return View(prs);
        }

        // GET: PersonnelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonnelController/Create
        public ActionResult Create()
        {
            ViewBag.x = departement.getAll();
            return View();
        }

        // POST: PersonnelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonnelTable collection)
        {
            personnel.Ajouter(collection);
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonnelController/Edit/5
        public ActionResult Edit(int id)
        {
            PersonnelTable x = personnel.getByid(id);
            ViewBag.x = departement.getAll();
            return View(x);
        }

        // POST: PersonnelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PersonnelTable collection)
        {
            personnel.Update(collection);
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonnelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonnelController/Delete/5
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
