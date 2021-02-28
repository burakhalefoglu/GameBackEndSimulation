using GameBackEndSimulation.DataAccess.Abstract;
using GameBackEndSimulation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEndSimulation.DataAccess.Concrete
{
    class CustomerDAL : ICustomerDAL
    {
        List<Customer> customers = new List<Customer>();

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public void Delete(Customer customer)
        {
            var obj = customers.FirstOrDefault(x => x.CustomerName == customer.CustomerName);
            customers.Remove(obj);
        }

        public List<Customer> Select()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            var obj = customers.FirstOrDefault(x => x.CustomerName == customer.CustomerName);
            if (obj != null) obj = customer;
        }
    }
}
