using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiafManagementStudio.ADO;
using SiafManagementStudio.Data;
using SiafManagementStudio.Models;
using SiafManagementStudio.Repository;

namespace SiafManagementStudio.Controllers
{
    [Authorize]
    public class EtudeController : Controller
    {
        private readonly IEtudeRepository etude;
        private readonly IPersonnelRepository personnel;
        private readonly IClientRepository client;
        public readonly ApplicationDbContext contexta;

        public EtudeController(IEtudeRepository etude, IPersonnelRepository personnel, IClientRepository client, ApplicationDbContext context)
        {
            this.etude = etude;
            this.personnel = personnel;
            this.client = client;
            this.contexta = context;
        }



        // GET: EtudeController
        public ActionResult Index()
        {
            ViewBag.datenow = DateTime.Now;
            List<etudeADO> eudes = new List<etudeADO>();
            List<EtudeTable> et = etude.FindAll();
            foreach (EtudeTable u in et)
            {

                string usename = contexta.Users.FirstOrDefault(x => x.Id == u.IdPersoNavigationId).Email.Replace("@siaf.com.tn", "");
                etudeADO etado = new etudeADO(u, usename);
                eudes.Add(etado);
            }
            return View(eudes);
        }

        // GET: EtudeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EtudeController/Create
        public ActionResult Create()
        {
            ViewBag.client = client.GetAll();

            return View();
        }

        // POST: EtudeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EtudeTable collection)
        {

            string last = etude.GetLastNumber();
            String[] t = last.Split("-");
            collection.IdPersoNavigationId = User.Identity.GetUserId();
            if (DateTime.Now.ToString("yy") != (t[0]))
            {
                collection.NumFicheTechnique = DateTime.Now.ToString("yy") + "-" + "001";
            }
            else
            {
                string newft = t[0];
                int x = int.Parse(t[1]) + 1;
                newft += "-" + x.ToString("000");
                collection.NumFicheTechnique = newft;
            }
            etude.add(collection);
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EtudeController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.client = client.GetAll();
            return View(etude.getbyId(id));
        }

        // POST: EtudeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EtudeTable collection)
        {
            try
            {
                etude.update(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult FinEtude(int id)
        {

            etude.SetEndEtude(id);

            return RedirectToAction("Index");

        }

        //public ActionResult DinProjet(int id)
        //{
        //    etude.SetENdProject(id);

        //    return View(Index);

        //}

        // GET: EtudeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EtudeController/Delete/5
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
