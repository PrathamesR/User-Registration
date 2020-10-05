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
            string name = Console.ReadLine();
            if (!Regex.IsMatch(name, "^[A-Z][A-Za-z]{2,}$"))
            {
                Console.WriteLine("First Name must start with Capital Letter and have atleast 3 letters");
                return false;
            }

            // Use Case 2
            Console.Write("Enter Valid Last Name: ");
            string lname = Console.ReadLine();
            if (!Regex.IsMatch(lname, "^[A-Z][A-Za-z]{2,}$"))
            {
                Console.WriteLine("Last Name must start with Capital Letter and have atleast 3 letters");
                return false;
            }

            // Use Case 3
            Console.Write("Enter Valid Email Address: ");
            string mail = Console.ReadLine();
            if (!Regex.IsMatch(mail, "^[A-Za-z]([A-Za-z0-9]+\\.{0,1})*@[a-z]+(\\.[a-z]{2,4})+(\\.[a-z]{2}){0,1}"))
            {
                Console.WriteLine("Invalid email format");
                return false;
            }

            //Use Case 4
            Console.Write("Enter Valid Phone Number: ");
            string pno = Console.ReadLine();
            if (!Regex.IsMatch(pno, "^[0-9]{2} [0-9]{10}$"))
            {
                Console.WriteLine("The number should be Country code follow by space and 10 digit number");
                return false;
            }

            //Use Case 5
            Console.Write("Enter Valid Password: ");
            string pass = Console.ReadLine();
            if (!Regex.IsMatch(pass, "^.{8,}$"))
            {
                Console.WriteLine("The password should contain minimum 8 characters");
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
