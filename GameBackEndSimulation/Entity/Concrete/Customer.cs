using GameBackEndSimulation.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEndSimulation.Entity.Concrete
{
    public class Customer : IDataModel
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerTc { get; set; }
        public string CustomerBirthyear { get; set; }
        public int WealthAmount { get; set; }
        public int CustomerItem { get; set; }

    }
}
