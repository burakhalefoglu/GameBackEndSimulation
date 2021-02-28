using GameBackEndSimulation.Business.Abstract;
using GameBackEndSimulation.DataAccess.Abstract;
using GameBackEndSimulation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEndSimulation.Business.Concrete
{
    class CampaignManager : ICampaignManager<Campaign>
    {
        ICampaignDAL campaignDAL;

        public CampaignManager(ICampaignDAL campaignDAL)
        {
            this.campaignDAL = campaignDAL;
        }

        public void AddCustomer(Campaign dataModel)
        {
            campaignDAL.Add(dataModel);
        }

        public void DeleteCustomer(Campaign dataModel)
        {
            campaignDAL.Delete(dataModel);
        }

        public void UpdateCustomer(Campaign dataModel)
        {
            campaignDAL.Update(dataModel);
        }

    }
}
