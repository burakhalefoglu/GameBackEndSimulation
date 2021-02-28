using GameBackEndSimulation.Adapter.Abstract;
using GameBackEndSimulation.Entity.Abstract;
using GameBackEndSimulation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEndSimulation
{
    public class CustomerValidationServices : ICustomerValidation
    {
        public bool ValidateCustomer(IDataModel dataModel)
        {
            return true;
        }
    }
}
