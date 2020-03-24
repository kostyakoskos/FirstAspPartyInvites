using Microsoft.AspNetCore.Mvc;
using System;
using PartyInvites.Models;
using System.Linq;

namespace Partylnvites.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "Hello world!";
        //}
        //public ViewResult Index()
        //{
        //    return View("MyView");
        //}
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good Afternoon";
            return View("MyView");
        }      

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();// можно и не указывать "RsvpForm"
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            // что делаем- сохранить ответ гостя
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                // обнаружена ошибка
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}