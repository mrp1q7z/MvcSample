using MultipleModels.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MultipleModels.Controllers
{
    public class MessagesController : Controller
    {
        // GET: Messages
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit(string id)
        {
            var recipients = new List<Recipient>();
            recipients.Add( new Recipient { ID = 1, PublicName = "public name 1", Email = "email1"} );
            recipients.Add( new Recipient { ID = 1, PublicName = "public name 2", Email = "email2"} );
            recipients.Add( new Recipient { ID = 1, PublicName = "publicName3", Email = "email3@exsample.com"} );

            var model = new Message();
            model.ID = Convert.ToInt32(id);
            model.Title = "title";
            model.Recipients = recipients;

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Title,Body,Recipients")] Message message)
        {
            var t = message.Title;
            var n = message.Recipients[0].PublicName;
            return View(message);
        }
    }
}