using Models;
using OnlineStore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class PhoneBL
    {
        MobileContext context;
        public PhoneBL(MobileContext _context)
        {
            this.context = _context;
        }
        public List<Phone> GetAll()
        {
            return context.Phones.ToList();
        }

        public Phone GetDetails(int id)
        {
            Phone phone = context.Phones.Where(x => x.Id == id).First();
            return phone;
        }

        public void Create(Phone phone)
        {
            context.Phones.Add(phone);
            context.SaveChanges();
        }
    }
}
