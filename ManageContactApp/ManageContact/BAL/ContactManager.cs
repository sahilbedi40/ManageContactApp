using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ManageContact.Models;
using ManageContact.DAL;
using ManageContact.Mapper;

namespace ManageContact.BAL
{
    public class ContactManager
    {
        private DBActivity db = new DBActivity(new ContactDBEntities());
        public ContactManager()
        {
           
        }
        public bool SaveEntity(ContactModel entity)
        {
            bool flag = false;
            try
            {
                db.SaveEntity(ContactMapper.ConvertModelToEntity(entity));
                db.SaveChanges();
                flag = true;
            }
            catch(Exception)
            {
                flag = false;
            }
            return flag;
        }

        public bool UpdateEntity(ContactModel entity)
        {
            bool flag = false;
            try
            {
                db.UpdateEntity(ContactMapper.ConvertModelToEntity(entity));
                db.SaveChanges();
                flag = true;
            }
            catch (Exception)
            {
                flag = false;
            }
            return flag;                      
        }

        public bool DeleteEntity(int id)
        {
            bool flag = false;
            try
            {
                db.DeleteEntity(id);
                db.SaveChanges();
                flag = true;
            }
            catch (Exception)
            {
                flag = false;
            }
            return flag;            
        }

        public List<ContactModel> GetContacts()
        {
           var list = db.GetContacts();
            List<ContactModel> contactList = new List<ContactModel>();
            foreach(var item in list)
            {
                contactList.Add(ContactMapper.ConvertEntityToModel(item));
            }

            return contactList;
        }
    }
}