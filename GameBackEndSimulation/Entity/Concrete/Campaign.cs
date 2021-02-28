using GameBackEndSimulation.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEndSimulation.Entity.Concrete
{
    public class Campaign : IDataModel
    {
        public int id { get; set; }
        public string CampaignName { get; set; }
        public int Discount { get; set; }

    }
}
