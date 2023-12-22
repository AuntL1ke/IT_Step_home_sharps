using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp19
{
    internal class Account
    {
        string email;
        string pass;
        private bool IsEmail(string email)
        {
            foreach (char c in email)
            {
                if (!char.IsLetterOrDigit(c) && c != '_' && c != '@')
                {
                    return false;
                }

                
            }
            return true;
        }
        private bool IsValidEmail(string email)
        {
            return email.Contains("@") && email.Length >= 4 && email.Length <= 50 && IsEmail(email);
        }
        private bool ContainsDigit(string pass)
        {
            foreach(char c in pass)
            {
                if(char.IsDigit(c))
                {
                    return true;    
                }
            }
            return false;
        }
        private bool ContainsLetter(string pass)
        {
            foreach (char c in pass)
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsPassword(string pass)
        {
            return pass.Length >= 6 && ContainsDigit(pass) && ContainsLetter(pass);
        }

        public string Email
        {
            get => email;
            set
            {
                if(IsValidEmail(value)) {
                    email = value;
                }
                else
                {
                    throw new InvalidOperationException("Invalid email");
                }
            }
        }

        public string Pass
        {
            get => pass;
            set
            {
                if(IsPassword(value))
                {
                    pass = value;
                }
                else
                {
                    throw new InvalidOperationException("Invalid password");
                }
            }
        }

        public void Input()
        {
            while(true)
            {
                Console.WriteLine("Input email(must be minimum 4 symbol length and maximum 50 symbol length and contain symbol @)");
                string input_em = Console.ReadLine();
                Console.WriteLine("Input password(must be minimum 6 symbol length and contains digits and letters)");
                string input_p = Console.ReadLine();
                try
                {
                    Email = input_em;
                    Pass = input_p;
                    break;
                }
                catch (Exception ex){
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again");
                }

            }
        }
    }
}

