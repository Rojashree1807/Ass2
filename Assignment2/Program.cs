using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String username="roja";
            string password="pass123";
            Console.WriteLine("Enter the user name");
            string enterusername = Console.ReadLine();
            Console.WriteLine("Enter the password");
            string enterpassword =Console.ReadLine();
            if (enterusername == username && enterpassword == password)
            {
                Console.WriteLine("Login successful! Welcome, " + username + "!");
            }
            else if(enterusername == username && enterpassword != password) 
            {
               
                Console.WriteLine("Invalid password.");
            }
            else if(enterusername != username && enterpassword == password)
            {

                Console.WriteLine("Invalid username.");
            }

            Console.ReadKey();
        }
    }
}
