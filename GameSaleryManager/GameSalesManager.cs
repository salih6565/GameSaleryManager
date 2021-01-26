using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleryManager
{
    class GameSalesManager
    {
        public string GameName { get; set; }
        public void GameSales(Customer customer, CampaignProperty campaıgnname, GameSalesManager gamename)
        {
            Console.WriteLine(customer.FirstName + " isimli kullanıcı ; " + campaıgnname.CampaıgnName + " kampanyası dahilinde " + gamename.GameName + " isimli oyunu aldı!");
        }
    }
}
