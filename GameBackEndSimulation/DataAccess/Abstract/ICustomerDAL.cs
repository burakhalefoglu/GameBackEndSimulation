using GameBackEndSimulation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEndSimulation.DataAccess.Abstract
{
    interface ICustomerDAL
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
        List<Customer> Select();
    }
}
