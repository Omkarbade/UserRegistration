using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("User Details")]
        public void USerDetails()
        {
            bool expected = true;
            string firstName = "Rahul";
            string lastName = "Gaikwad";
            string emailID = "Rahul122@ggmail.com";
            string monum = "91 8190538095";
            string password = "Ifelse@du1";
            UserRegistration1 pattern = new UserRegistration1();
            Assert.AreEqual(expected, pattern.ValidateFName(firstName));
            Assert.AreEqual(expected, pattern.ValidateLName(lastName));
            Assert.AreEqual(expected, pattern.ValidateEmail(emailID));
            Assert.AreEqual(expected, pattern.ValidateMobileNumber(monum));
            Assert.AreEqual(expected, pattern.ValidatePasswordRule4(password));
        }
        //testing all emails samples
        [TestMethod]
        [TestCategory("Sample Emails")]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
         public void ValidateEmailId(string email)
         {
            bool expected = true;
            UserRegistration1 pattern = new UserRegistration1();  
            Assert.AreEqual(expected, pattern.ValidateEmail(email));
         }
    }
}
