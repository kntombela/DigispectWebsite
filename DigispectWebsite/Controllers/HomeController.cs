using DigispectWebsite.DAL;
using DigispectWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DigispectWebsite.Controllers
{
    public class HomeController : Controller
    {
        private DigispectDbContext db = new DigispectDbContext();

        public ActionResult Index()
        {
            return View();
        }

        // POST: Home/Index
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index([Bind(Include = "Name,Email")] Lead lead)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    db.Leads.Add(lead);
                    await db.SaveChangesAsync();
                    TempData["Message"] = "Thank you for subscribing " + lead.Name + ", we'll be in contact shortly!";
                    return RedirectToAction("Index");
                }

            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Please Try again, and if the problem persists see contact page.");
            }

            return View(lead);
        }

        public ActionResult Contact()
        {
            return View();
        }

    }
}