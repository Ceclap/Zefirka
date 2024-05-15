using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zefirka.BuisnessLogic;
using Zefirka.Domain.Entites.Responce;
using Zefirka.Domain.Entites.User;
using Zefirka.Domain.User;
using Zefirka.Models;
using ZefirkaBuisnessLogic.Interfaces;

namespace Zefirka.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        private readonly ISession _session;

        public RegisterController()
        {
            var bl = new BussinessLogic();
            _session = bl.GetSessionBL();
        }
        public ActionResult SignIn()
        {

            return View();
        }
        // GET : Register
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult SignIn(UserRegister data)

        {
            if (ModelState.IsValid)
            {
                URegisterData uData = new URegisterData
                {
                    Credential = data.Credential,
                    Password = data.Password,
                    ConfirmPassword = data.ConfirmPassword,
                    LoginIp = Request.UserHostAddress,
                    LoginDateTime = DateTime.Now,

                };
                ULoginResp resp = _session.RegisterNewUserAction(uData);
                if (resp.Status)
                {
                    ULoginData user = new ULoginData
                    {
                        Credential = data.Credential,
                        Password = data.Password
                    };

                    _session.UserLoginAction(user);

                    //HttpCookie cookie = _session.GenCookie(user.Credential);
                    //ControllerContext.HttpContext.Response.Cookies.Add(cookie);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", resp.ActionStatusMsg);
                    return View();
                }
            }
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}