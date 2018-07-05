using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ManageContact.Models;

namespace ManageContact.DAL
{
    public class DBActivity
    {
        private ContactDBEntities dbContext;
        public DBActivity(ContactDBEntities context)
        {
            dbContext = context;
        }

        public void SaveEntity(Contact entity)
        {
            dbContext.Contacts.Add(entity);            
        }

        public void UpdateEntity(Contact entity)
        {
            Contact record = dbContext.Contacts.Find(entity.Id);
            record.FirstName = entity.FirstName;
            record.LastName = entity.LastName;
            record.Email = entity.Email;
            record.PhoneNumber = entity.PhoneNumber;
            record.ContactStatus = entity.ContactStatus;            
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        public void DeleteEntity(int id)
        {
            Contact entity = dbContext.Contacts.Find(id);
            dbContext.Contacts.Remove(entity);
        }

        public List<Contact> GetContacts()
        {
            return dbContext.Contacts.ToList();
        }
    }
}