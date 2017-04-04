using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demo.Models;

namespace Demo.Repositoryes
{
    public class CustomerRepository : IGenericRepository<Customer>
    {
        ApplicationDbContext _context = new ApplicationDbContext();

        public void Add(Customer entity)
        {
            _context.Customers.Add(entity);
            _context.SaveChanges();
        }

        public void Edit(Customer entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remove(Customer entity)
        {
            _context.Customers.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers;
        }

        public Customer FindById(int entityId)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == entityId);
            return customer;
        }
    }
}