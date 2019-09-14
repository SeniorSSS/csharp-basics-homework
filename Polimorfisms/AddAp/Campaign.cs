using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddAp
{
    public class Campaign
    {
        //bija private. Kā tikt no program print neattaisot private???
        private List<Advert> _campaign;


        public List<Advert> campaign
        {
            get => _campaign;
            set => _campaign = value;
        }

        public Campaign()
        {
            campaign = new List<Advert>();
        }

        public void AddAdvert(Advert a)
        {
            campaign.Add(a);
        }

        public int GetCost()
        {
            return campaign.Sum(item => item.Cost());
        }

        public override string ToString()
        {
            return "Advert Campaign" + campaign + "\nTotal Cost = " + GetCost();
        }
    }
}
