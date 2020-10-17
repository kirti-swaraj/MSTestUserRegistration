using System;
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------
namespace MSTestForUserRegistration
{
    class Program
    {/// <summary>
    /// Going into main method
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
       
            {
                UserInput();
        }
        /// <summary>
        /// Creating the method to take user input.
        /// </summary>
/// <summary>
/// Users the input.
/// </summary>
/// <returns></returns>
      static void UserInput()
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1. Validate First Name \n2. Validate Last Name\n3. Validate Email " +
                                        "\n4. Validate Mobile Number \n5. Validate Password \n6. Exit");
                    string option = Console.ReadLine();
                    switch (option)
                    {
                    // Asking for first name
                    case "1":
                            Console.WriteLine("Enter First Name");
                            string firstName = Console.ReadLine(); 
                /// trying to catch the exception when invalid input is entered.
                try
                {
                    Console.WriteLine("{0}", UserEntries.IsValidName(firstName) ? "Valid" : "Invalid"); // Ternary operator
                }
                catch (UserEntriesException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
                 // Asking for last name
                    case "2":
                        Console.WriteLine("Enter Last Name");
                string lastName = Console.ReadLine();
                 /// trying to catch the exception when invalid input is entered.
                try
                {
                    Console.WriteLine("{0}", UserEntries.IsValidName(lastName) ? "Valid" : "Invalid"); // Ternary operator
                }
                catch (UserEntriesException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
                // Asking for Email
                    case "3":
                        Console.WriteLine("Enter Email");
                string email = Console.ReadLine();
               /// trying to catch the exception when invalid input is entered.
                try
                {
                    Console.WriteLine("{0}", UserEntries.IsValidEmail(email) ? "Valid" : "Invalid"); // Ternary operator
                }
                catch (UserEntriesException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
                // Asking for Moblie Number
                    case "4":
                        Console.WriteLine("Enter Mobile Number");
                string mobileNumber = Console.ReadLine();
                /// trying to catch the exception when invalid input is entered.         
                try
                {
                    Console.WriteLine("{0}", UserEntries.IsValidMobileNumber(mobileNumber) ? "Valid" : "Invalid"); // Ternary operator
                }
                catch (UserEntriesException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
                // Asking for Password
                    case "5":
                        Console.WriteLine("Enter Password");
                string password = Console.ReadLine();
                /// trying to catch the exception when invalid input is entered.                
                try
                        {
                    Console.WriteLine("{0}", UserEntries.IsValidPassword(password) ? "Valid" : "Invalid"); // Ternary operator
                }
                catch (UserEntriesException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
                default:
                        flag = false; // To break loop

                        break;
                }
            }
        }
    }
}
