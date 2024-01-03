using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            /*   Account account = new Account();
               account.Input();
               Console.WriteLine(account.Email);
               Console.WriteLine(account.Pass);*/


            // 2
           

            // Введення валідних даних
            try
            {
                CreditCard myCard = new CreditCard();

                // Введення валідних даних
                myCard.Name = "John Doe";
                myCard.Number = "1234567890123456";
                myCard.ExpirationDate = "12/25";
                myCard.Cvv = "123";

                // Виведення валідних даних
                Console.WriteLine($"Name: {myCard.Name}");
                Console.WriteLine($"Number: {myCard.Number}");
                Console.WriteLine($"Expiration Date: {myCard.ExpirationDate}");
                Console.WriteLine($"CVV: {myCard.Cvv}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                
            }
        }
    }




}
    

