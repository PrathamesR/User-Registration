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

        /// <summary>
        /// Gets the user details and performs Regex validation.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="ExceptionMsg">The exception message.</param>
        /// <returns></returns>
        public static string GetDetail(string pattern, string ExceptionMsg)
        {
            try
            {
                String value = Console.ReadLine();

                Func<string, string, string> checkRegex = (input, patt) =>
                {
                    if (Regex.IsMatch(input, patt))
                        return input;
                    else
                        throw new UserDetailException(ExceptionMsg);
                };

                return checkRegex(value, pattern);
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }


        /// <summary>
        /// Registers the user.
        /// </summary>
        /// <returns></returns>
        static bool RegisterUser()
        {
            //Use Case 1
            Console.Write("Enter Valid First Name: ");
            string name = GetDetail("^[A-Z][A-Za-z]{2,}$", "First Name must start with Capital Letter and have atleast 3 letters");
            if (name==null)
                return false;

            // Use Case 2
            Console.Write("Enter Valid Last Name: ");
            string lname = GetDetail("^[A-Z][A-Za-z]{2,}$", "Last Name must start with Capital Letter and have atleast 3 letters");
            if (lname == null)
                return false;

            // Use Case 3
            Console.Write("Enter Valid Email Address: ");
            string mail = GetDetail(@"^[A-Za-z]([A-Za-z0-9]+\.{0,1}[\-\+\*\!_]*)*[a-zA-Z0-9]+@[a-z0-9]+(\.[a-z]{2,4})(\.[a-z]{2,4}){0,1}", "Invalid email format");
            if (mail == null)
                return false;

            //Use Case 4
            Console.Write("Enter Valid Phone Number: ");
            string phoneNo = GetDetail("^\\+{0,1}[0-9]{2} [0-9]{10}$", "The number should be Country code follow by space and 10 digit number");
            if (phoneNo == null)
                return false;

            //Use Case 8
            Console.Write("Enter Valid Password: ");
            string pass = GetDetail(@"^(^(?=.{8,}$))(?=.*[A-Z])(?=.*[0-9])(^[a-zA-Z0-9]*[!@#$^&*()\-+=]{1}[a-zA-Z0-9]*$)", "The password should contain minimum 8 characters and a Capital Letter and exactly 1 special character");
            if (pass == null)
                return false;
            
            Console.WriteLine("\nUser Details-\nName:"+name+" "+lname+" Mail: "+mail+" Password: "+pass+"\n");
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
