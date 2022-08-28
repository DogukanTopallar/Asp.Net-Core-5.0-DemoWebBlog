using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager: IContactService
    {
        IContactDal _cantactdal;

        public ContactManager(IContactDal cantactdal)
        {
            _cantactdal = cantactdal;
        }

        public void ContactAdd(Contact contact)
        {
            _cantactdal.Insert(contact);
        }
    }
}
