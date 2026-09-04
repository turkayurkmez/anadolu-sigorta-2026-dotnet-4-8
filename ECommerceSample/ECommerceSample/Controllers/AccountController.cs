using ECommerceSample.Models;
using ECommerceSample.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ECommerceSample.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserLoginModel userLogin, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = new UserService().ValidateUser(userLogin.UserName, userLogin.Password);
                if (user != null)
                {

                    var claims = new List<Claim>
                {
                     new Claim(ClaimTypes.Name, user.UserName),
                     new Claim(ClaimTypes.Role,user.Role)
                };

                  

                    ClaimsIdentity identity = new ClaimsIdentity(claims, FormsAuthentication.FormsCookieName);
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                    HttpContext.User = claimsPrincipal;


                    if (User.IsInRole("admin"))
                    {
                        Debug.WriteLine("admin rolünde");
                    } 

                    FormsAuthentication.SetAuthCookie(userLogin.UserName, true);
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    return Redirect("/");

                }
                ViewBag.Error = "Kullanıcı adı veya şifre hatalı";

            }
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            //if (ModelState.IsValid)
            //{
            //    if (!Roles.RoleExists("admin"))
            //    {
            //        Roles.CreateRole("admin");
            //    }

            //    Roles.AddUserToRole(user.UserName, "user");

            //}
            if (ModelState.IsValid)
            {
                var userService = new UserService();
                user.Role = "customer";
                userService.RegisterUser(user);
                return Redirect("/");

            }
            return View();
        }

    }
}