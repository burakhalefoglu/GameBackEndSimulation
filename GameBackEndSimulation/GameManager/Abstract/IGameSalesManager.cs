using GameBackEndSimulation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEndSimulation.GameManager
{
    public interface IGameSalesManager
    {
        void SaleSomething(Product product, Customer customer, Campaign campaign);

    }
}
