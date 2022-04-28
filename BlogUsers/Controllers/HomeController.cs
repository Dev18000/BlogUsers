using BlogUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.Logic.UsersDB;

namespace BlogUsers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(UsersModel user)
        {
            if (ModelState.IsValid)
            {
                CreateUser(user.Age, user.Name, user.Surname, user.Email, user.Password);

                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public ActionResult ViewUsers()
        {
            var data = LoadUsers();
            List<UsersModel> users = new List<UsersModel>();

            foreach (var user in data)
            {
                users.Add(new UsersModel
                {
                    Age = user.Age,
                    Name = user.Name,
                    Surname = user.Surname,
                    Email = user.Email,
                    Password = user.Password
                });
            }

            return View(users);
        }
    }
}