using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ManageContact.BAL;
using ManageContact.Models;

namespace ManageContact.Controllers
{
    [RoutePrefix("api/Contact")]
    public class ContactController : ApiController
    {
        private ContactManager manager = new ContactManager();

        [Route("GetContacts")]
        [HttpGet]
        public IHttpActionResult GetContacts()
        {
            List<ContactModel> contactList = manager.GetContacts();
            return Ok(contactList);
        }

        [Route("Create")]
        [HttpPost]
        public IHttpActionResult CreateContact(ContactModel model)
        {
            bool flag= manager.SaveEntity(model);
            if (flag)
                return Ok("success");
            else
                return Ok("error");
        }

        [Route("Edit")]
        [HttpPost]
        public IHttpActionResult EditContact(ContactModel model)
        {
            bool flag = manager.UpdateEntity(model);
            if (flag)
                return Ok("success");
            else
                return Ok("error");
        }

        [Route("Delete")]
        [HttpPost]
        public IHttpActionResult DeleteContact(int id)
        {
            bool flag = manager.DeleteEntity(id);
            if (flag)
                return Ok("success");
            else
                return Ok("error");
        }
    }
}
