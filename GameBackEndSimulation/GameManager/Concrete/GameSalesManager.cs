using GameBackEndSimulation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEndSimulation.GameManager.Concrete
{
    public class GameSalesManager : IGameSalesManager
    {
        public void SaleSomething(Product product, Customer customer, Campaign campaign)
        {
            int newPrice = product.ProductPrice * (100 - campaign.Discount) / 100;

            if (newPrice <= customer.WealthAmount)
            {
                customer.WealthAmount -= product.ProductPrice;
                customer.CustomerItem++;

            }
        }
    }
}
