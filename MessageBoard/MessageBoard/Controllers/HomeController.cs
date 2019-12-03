using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MessageBoard.Models;
using MessageBoard.Services;
using MessageBoard.ViewModels;

namespace MessageBoard.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private readonly MessageDBService messageDBService = new MessageDBService();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            MessageViewModel data = new MessageViewModel();
            data.DataList = messageDBService.GetMessages();
            return PartialView(data);
        }

        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult CreateMessage(Message Data)
        {
            if (!TryUpdateModel< Message > (Data))
            {
                TempData["Message"] = "驗證失敗!";
            }
            else
            {
                Data.Create_Time = DateTime.Now;
                messageDBService.CreateMessage(Data);
                TempData["Message"] = "新增成功!";
            }
            return RedirectToAction("List");
        }

        public ActionResult Edit(int id)
        {
            Message data = messageDBService.FindMessage(id);
            return View(data);
        }

        [HttpPost]
        public ActionResult EditMessage(Message Data)
        {
            if(!TryUpdateModel<Message> (Data))
            {
                TempData["Message"] = "驗證失敗！";
            }
            else
            {
                messageDBService.EditMessage(Data);
                TempData["Message"] = "更新成功！";
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            messageDBService.DeleteMessage(id);
            return RedirectToAction("List");
        }
    }
}