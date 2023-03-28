using Microsoft.AspNetCore.Mvc;
using SiafManagementStudio.Models;
using SiafManagementStudio.Repository;

namespace SiafManagementStudio.Controllers
{
    public class ClientController : Controller
    {
        private IClientRepository Client;
        public ClientController(IClientRepository cl)
        {
            this.Client = cl;
        }

        // GET: ClientController
        public ActionResult Index()
        {
            return View(Client.GetAll());
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientTable collection)
        {
            Client.AjouterClient(collection);
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Client.findById(id));
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ClientTable collection)
        {
            try
            {
                Client.updateClient(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
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
