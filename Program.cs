using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    class Program
    {

        static bool RegisterUser()
        {
            //Use Case 1
            Console.Write("Enter Valid First Name: ");
            string name=Console.ReadLine();
            if (!Regex.IsMatch(name, "[A-Z][a-z]{3,}"))
            {
                Console.WriteLine("Name must start with Capital Letter and have atleast 3 letters");
                return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");

            if (RegisterUser())
                Console.WriteLine("User Registered successfully");


            //Temp Read Line to view console
            Console.ReadLine();
        }
    }
}
