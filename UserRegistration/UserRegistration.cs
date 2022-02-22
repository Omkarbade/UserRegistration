using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserRegistration1
    {
        //Declaring Constant Variables for Patterns
        public const string FIRST_NAME = "^[A-Z][a-zA-Z]{2}";
        public const string LAST_NAME = "^[A-Z][a-zA-Z]{2}";
        public const string EMAIL = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public const string MOBILE_NO = "^([9][1])+[ ]+[6789]{1}[0-9]{9}$";
        public const string PASSWORD_RULE1 = "^[a-z]{8}";
        public const string PASSWORD_RULE2 = "^(?=.*[a-z])(?=.*[A-Z]).{8,}$";
        public const string PASSWORD_RULE3 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        public const string PASSWORD_RULE4 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&-+=()]).{8,}$";

        //declaring Array
        public string[] sampleEmail = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc-100@abc.net", "abc.100@abc.com.au",
                 "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" ,"abc","abc@.com","abc123@gmail.a", "abc123@.com" ,
                 "abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc.2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a", "abc@gmail.com.aa.au" };

        //Method to check First Name
        public bool ValidateFName(string fName)
        {
            //using regex constructor and assigning pattern
            Regex regex = new Regex(FIRST_NAME);

            if (regex.IsMatch(fName))
            {
                Console.WriteLine("first name is matched with pattern");
                return true;
            }
            else
            {
                Console.WriteLine("first name does not match with pattern");
                throw new UserException(UserException.ExceptionType.INVALID_FIRSTNAME, "Invalid first name");
            }
        }
        //Method to check Last Name
        public bool ValidateLName(string lName)
        {
            //using regex constructor and assigning pattern
            Regex regex = new Regex(LAST_NAME);

            if (regex.IsMatch(lName))
            {
                Console.WriteLine("Last name is matched with pattern");
                return true;
            }
            else
            {
                Console.WriteLine("Last name does not match with pattern");
                throw new UserException(UserException.ExceptionType.INVALID_LASTNAME, "Invalid last name");
            }
        }
        //Method to check Email id
        public bool ValidateEmail(string emailId)
        {
            ///using regex constructor and assigning pattern
            Regex regex = new Regex(EMAIL);

            if (regex.IsMatch(emailId))
            {
                Console.WriteLine("Email id is matched with pattern");
                return true;
            }
            else
            {
                Console.WriteLine("Email id not matched with pattern");
                throw new UserException(UserException.ExceptionType.INVALID_EMAILID, "Invalid Email id");
            }
        }
        //Method to check Mobile number
        public bool ValidateMobileNumber(string monum)
        {
            //using regex constructor and assigning pattern
            Regex regex = new Regex(MOBILE_NO);

            if (regex.IsMatch(monum))
            {
                Console.WriteLine("Mobile Number is matched with pattern");
                return true;
            }
            else
            {
                Console.WriteLine("Mobile Number not matched with pattern");
                throw new UserException(UserException.ExceptionType.INVALID_MOBILENO, "Invalid mobile no");
            }
        }
        //method to check password
        public void ValidatePasswordRule1(string password1)
        {
            //using regex constructor and assigning pattern
            Regex regex = new Regex(PASSWORD_RULE1);

            if (regex.IsMatch(password1))
            {
                Console.WriteLine("PassWord is matched with pattern");
            }
            else
            {
                Console.WriteLine("PassWord not matched with pattern");
            }
        }
        //method to check password 
        public void ValidatePasswordRule2(string password2)
        {
            //using regex constructor and assigning pattern
            Regex regex = new Regex(PASSWORD_RULE2);

            if (regex.IsMatch(password2))
            {
                Console.WriteLine("PassWord is matched with pattern");
            }
            else
            {
                Console.WriteLine("PassWord not matched with pattern");
            }
        }
        //method to check password 
        public void ValidatePasswordRule3(string password3)
        {
            //using regex constructor and assigning pattern
            Regex regex = new Regex(PASSWORD_RULE3);

            if (regex.IsMatch(password3))
            {
                Console.WriteLine("PassWord is matched with pattern");
            }
            else
            {
                Console.WriteLine("PassWord not matched with pattern");
            }
        }
        //method to check password 
        public bool ValidatePasswordRule4(string password4)
        {
            //using regex constructor and assigning pattern
            Regex regex = new Regex(PASSWORD_RULE4);

            if (regex.IsMatch(password4))
            {
                Console.WriteLine("PassWord is matched with pattern");
                return true;
            }
            else
            {
                Console.WriteLine("PassWord not matched with pattern");
                throw new UserException(UserException.ExceptionType.INVALID_PASSWORD, "Invalid password");
            }
        }
       
        

    }
}

