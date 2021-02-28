using GameBackEndSimulation.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEndSimulation.Adapter.Abstract
{
    public interface ICustomerValidation
    {
        bool ValidateCustomer(IDataModel dataModel);
    }
}
