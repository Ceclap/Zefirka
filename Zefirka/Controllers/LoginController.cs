using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zefirka.BuisnessLogic;
using Zefirka.Domain.Entites.Responce;
using Zefirka.Domain.User;
using Zefirka.Models;
using ZefirkaBuisnessLogic.Interfaces;

namespace Zefirka.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISession _session;

        // GET: Register
        public LoginController()
        {
            var bl = new BussinessLogic();
            _session = bl.GetSessionBL();
        }
        public ActionResult LogIn()
        {
            return View();
        }

        // GET : Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(LoginData data)

        {
            if (ModelState.IsValid)
            {
                ULoginData uData = new ULoginData
                {
                    Credential = data.Credential,
                    Password = data.Password,
                    LoginIp = Request.UserHostAddress,
                    LoginDateTime = DateTime.Now,
                };
                ULoginResp resp = _session.UserLoginAction(uData);
                if (resp.Status)
                {
                    if (resp.Message == "Admin")
                        //ADD COOKI
                        return RedirectToAction("login", "Home");


                    return RedirectToAction("login", "Home");
                }
                else
                {
                    ModelState.AddModelError("", resp.ActionStatusMsg);
                    return View();
                }
            }
            return View();
        }



    }
}