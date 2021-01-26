using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleryManager
{
    interface ICampaignManager
    {
        void Add(CampaignProperty campaıgnname);
        void Update(CampaignProperty campaıgnname);
        void Delete(CampaignProperty campaıgnname);
    }
}
