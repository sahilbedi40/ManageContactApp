using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ManageContact.Models;

namespace ManageContact.Mapper
{
    public  class ContactMapper
    {
        public static Contact ConvertModelToEntity(ContactModel model)
        {
            return new Contact()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                ContactStatus = model.ContactStatus,
                Id = model.Id,
                PhoneNumber = model.PhoneNumber
            };
        }

        public static ContactModel ConvertEntityToModel(Contact model)
        {
            return new ContactModel()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                ContactStatus = model.ContactStatus,
                Id = model.Id,
                PhoneNumber = model.PhoneNumber
            };
        }
    }
}