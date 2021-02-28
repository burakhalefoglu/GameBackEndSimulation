using GameBackEndSimulation.DataAccess.Abstract;
using GameBackEndSimulation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEndSimulation.DataAccess.Concrete
{
    class CampaignDAL : ICampaignDAL
    {
        List<Campaign> campaigns = new List<Campaign>();

        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
                }

        public void Delete(Campaign campaign)
        {
            var obj = campaigns.FirstOrDefault(x => x.CampaignName == campaign.CampaignName);
            campaigns.Remove(obj);
        }

        public List<Campaign> Select()
        {
            throw new NotImplementedException();
        }

        public void Update(Campaign campaign)
        {
            var obj = campaigns.FirstOrDefault(x => x.CampaignName == campaign.CampaignName);
            if (obj != null) obj = campaign;
        }
    }
}
