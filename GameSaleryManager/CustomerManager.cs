using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleryManager
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + ":isimli Kullanıcı Eklendi");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + ":isimli Kullanıcı Silindi");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + ":isimli  Kullanıcı güncellendi");
        }
    }
}
