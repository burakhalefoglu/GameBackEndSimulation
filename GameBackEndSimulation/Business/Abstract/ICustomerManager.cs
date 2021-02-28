using GameBackEndSimulation.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEndSimulation.Business.Abstract
{
    public interface ICustomerManager <T>
    {
        void AddCustomer(T dataModel);
        void DeleteCustomer(T dataModel);
        void UpdateCustomer(T dataModel);
    }
}
