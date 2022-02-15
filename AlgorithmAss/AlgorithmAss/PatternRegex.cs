using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgorithmAss
{
    public class PatternRegex
    {
        //creating objects(first&last name,phone no. datetime) of regex class
        public readonly Regex firstName = new Regex(@"([A_Z]{1}[a-z]{2,}$)");
        public readonly Regex lastName = new Regex(@"([A_Z]{1}[a-z]{2,}$)");
        public readonly Regex phoneNumber = new Regex(@"([\+91][ ][0-9]{10}$)");
        public readonly Regex dateAndTime = new Regex(@"(^(0?[1-9]|[12][0-9]|3[01])[\/\/-](0?[1-9]|1[012])[\/-]20[0-9]{2}$");
        //instace variable
        public string nameFirst, nameLast,phNumber,dateTimeTodays;
        public readonly DateTime date= DateTime.Now;

        //Constructor 
        public PatternRegex()
        {
            this.nameFirst = null;
            this.nameLast = null;
            phNumber = null;
            dateTimeTodays = null;
        }

        //Method 1:Checking first name valid or not
        public bool FirstName()
        {
            Console.WriteLine("Enter first name(First letter is in capital)");
            nameFirst=Console.ReadLine();
            if(firstName.IsMatch(nameFirst))
                return true;
            else
            {
                Console.WriteLine("Name not valid");
                FirstName();
            }
            return false;
        }

        //Method 2:Checking last name valid or not
        public bool LastName()
        {
            Console.WriteLine("Enter last name(First letter is in capital)");
            nameLast = Console.ReadLine();
            if (lastName.IsMatch(nameLast))
                return true;
            else
            {
                Console.WriteLine("Name not valid");
                LastName();
            }
            return false;
        }

        //Method 3:Checking phone number
        public bool PhoneNumber()
        {
            Console.WriteLine("Enter phone number(please enter number in +91 8765432199 format) ");
            phNumber = Console.ReadLine();
            if(phoneNumber.IsMatch(phNumber))
                return true;
            else
            {
                Console.WriteLine("phone number not valid");
                PhoneNumber();
            }
            return true;
        }

        //Method 4:Checking date time
        public bool TodaysDate()
        {
            Console.WriteLine("Enter todays date in DD/MM/YYYY format: ");
            dateTimeTodays=Console.ReadLine();
            if(dateAndTime.IsMatch(dateTimeTodays))
                return true;
            else
            {
                Console.WriteLine("date format not matched or invalid");
                TodaysDate();
            }
            return false;
        }

        //Method 5: printing message
        public void Message()
        {
            Console.WriteLine("Hello "+nameFirst+"We have your full name as "+nameFirst + nameLast+"in our system.your" +
                "contact number is "+ phNumber +"Please, let us know in case of any clarification Thank you BridgeLabz "+dateTimeTodays );
        }
    }
}
