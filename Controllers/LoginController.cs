using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CST247CLC.Models;
using CST247CLC.Services.Business;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace CST247CLC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserModel userModel)
        {
            int ID = -1;
            //var json = JsonSerializer.Serialize(userModel);
            UserBusinessService ubs = new UserBusinessService();
            ID = ubs.loginUser(userModel);
            if (ID > 0)
            {
                ViewBag.username = userModel.userName;
                HttpContext.Session.SetInt32("userId", ID);
                return View("Views/Login/LoginSuccess.cshtml");
            }
            else
            {
                return View("Views/Login/LoginFail.cshtml");
            }

        }


    }
}