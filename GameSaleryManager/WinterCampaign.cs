using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleryManager
{
    class WinterCampaign
    {
        public void Add(CampaignProperty campaıgnname)
        {
            Console.WriteLine(campaıgnname.CampaıgnName + " adlı yeni bir kampanya eklendi!");
        }

        public void Update(CampaignProperty campaıgnname)
        {
            Console.WriteLine(campaıgnname.CampaıgnName + " adlı kampanya güncellendi!");
        }

        public void Delete(CampaignProperty campaıgnname)
        {
            Console.WriteLine(campaıgnname.CampaıgnName + " adlı kampanya silindi!");
        }
    }
}
