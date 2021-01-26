using System;

namespace GameSaleryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Salih";
            customer1.LastName = "Kara";
            customer1.Age = 16;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Ümit";
            customer2.LastName = "Kara";
            customer2.Age = 10;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Miraç";
            customer3.LastName = "Kara";
            customer3.Age = 11;

            GameSalesManager game1 = new GameSalesManager();
            game1.GameName = "CyberPunk_2077";
            GameSalesManager game2 = new GameSalesManager();
            game2.GameName = "GTA_5";

            CampaignProperty WinterCampaıgn = new CampaignProperty();
            WinterCampaıgn.CampaıgnName = "kış kampanyası";

            CampaignProperty SummerCampaıgn = new CampaignProperty();
            SummerCampaıgn.CampaıgnName = "yaz kampanyası";

            CampaignProperty WeekEndCampaıgn = new CampaignProperty();
            WeekEndCampaıgn.CampaıgnName = "haftasonu kampanyası";

            WeekEndCampaign weekEndCampaıgn = new WeekEndCampaign();
            SummerCampaign summerCampaıgn = new SummerCampaign();
            WinterCampaign winterCampaıgn = new WinterCampaign();
            VerificationManager verificationManager = new VerificationManager();
            CustomerManager customers = new CustomerManager();
            customers.Add(customer1);
            Console.WriteLine("------------------------");
            customers.Delete(customer2);
            Console.WriteLine("------------------------");
            customers.Update(customer3);
            verificationManager.Verify(customer2);
            Console.WriteLine("------------------------");
            Console.WriteLine("---------KAMPANYA İŞLEMLERİ----------");
            weekEndCampaıgn.Add(WinterCampaıgn);
            summerCampaıgn.Delete(SummerCampaıgn);
            winterCampaıgn.Update(WeekEndCampaıgn);

            Console.WriteLine("--------OYUN SATIŞI--------");
            GameSalesManager gameSalesManager = new GameSalesManager();
            gameSalesManager.GameSales(customer1, WinterCampaıgn, game1);

        }
    }
}
