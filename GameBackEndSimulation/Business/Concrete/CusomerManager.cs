using GameBackEndSimulation.Adapter.Abstract;
using GameBackEndSimulation.Business.Abstract;
using GameBackEndSimulation.DataAccess.Abstract;
using GameBackEndSimulation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEndSimulation
{
    class CusomerManager: ICustomerManager <Customer>
    {
        ICustomerDAL customerDAL;
        ICustomerValidation customerValidation;
        public CusomerManager(ICustomerDAL customerDAL, ICustomerValidation customerValidation
            )
        {
            this.customerDAL = customerDAL;
            this.customerValidation = customerValidation;
        }

        public void AddCustomer(Customer dataModel)
        {
            if(customerValidation.ValidateCustomer(dataModel))
            customerDAL.Add(dataModel);
        }

        public void DeleteCustomer(Customer dataModel)
        {
            customerDAL.Delete(dataModel);
        }

        public void UpdateCustomer(Customer dataModel)
        {
            customerDAL.Update(dataModel);

        }
    }
}
