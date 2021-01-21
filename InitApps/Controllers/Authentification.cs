using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InitApps.Controllers
{
    public class Authentification : Controller
    {
        // GET: Authentification
        [Route("/Login")]
        public ActionResult Login()
        {
            return View();
        }

        [Route("/Register")]
        public ActionResult Register()
        {
            return View();
        }
        [Route("/RegisterConfirm")]
        public ActionResult RegisterConfirm()
        {
            return View();
        }
        [Route("/ForgetPassword")]
        public ActionResult ForgotPassword()
        {
            return View();
        }
        [Route("/ResetPassword")]
        public ActionResult ResetPassword()
        {
            return View();
        }
        // GET: Authentification/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Authentification/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Authentification/Create
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

        // GET: Authentification/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Authentification/Edit/5
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

        // GET: Authentification/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Authentification/Delete/5
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
