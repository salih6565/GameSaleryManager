using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleryManager
{
    class VerificationManager
    {
        public void Verify(Customer customer)
        {
            Console.WriteLine("---------E-Devlet Doğrulaması------------");
            Console.WriteLine("Kullanıcı ismi :" + customer.FirstName);
            Console.WriteLine("Kullanıcı soyadı :" + customer.LastName);
            Console.WriteLine("Kullanıcı Id  si :" + customer.Id);
            Console.WriteLine("Kullanıcı yaşı :" + customer.Age);
        }
    }
}
