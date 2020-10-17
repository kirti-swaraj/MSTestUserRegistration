using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestForUserRegistration;

namespace TestUserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Kirti", true)]
        [DataRow("kirti", false)]
        [DataRow("Kir5ty", false)]
        [DataRow("Swaraj", true)]
        [DataRow("KI", false)]
        [DataRow("1Kirti", false)]
        public void TestIsValidName(string name, bool expected)
        {
            try
            {
                //Arrange
                //Act
                bool actual = UserEntries.IsValidName(name);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (UserEntriesException ex)
            {
                string actualMessage = ex.Message;
                string expectedMessage = "Enter Valid Name!";
                //Assert
                Assert.AreEqual(expectedMessage, actualMessage);
            }
        }

        [TestMethod]
        [DataRow("abc@yahoo.com", true)]
        [DataRow("abc-100@yahoo.com", true)]
        [DataRow("abc.100@yahoo.com", true)]
        [DataRow("abc111@abc.com", true)]
        [DataRow("abc-100@abc.net", true)]
        [DataRow("abc.100@abc.com.au", true)]
        [DataRow("abc@1.com", true)]
        [DataRow("abc@gmail.com.com", true)]
        [DataRow("abc+100@gmail.com", true)]
        [DataRow("abc", false)]
        [DataRow("abc@.com.my", false)]
        [DataRow("abc123@gmail.a", false)]
        [DataRow("abc123@.com", false)]
        [DataRow("abc123@.com.com", false)]
        [DataRow(".abc@abc.com", false)]
        [DataRow("abc()*@gmail.com", false)]
        [DataRow("abc@%*.com", false)]
        [DataRow("abc..2002@gmail.com", false)]
        [DataRow("abc.@gmail.com", false)]
        [DataRow("abc@abc@gmail.com", false)]
        [DataRow("abc@gmail.com.1a", false)]
        [DataRow("abc@gmail.com.aa.au", false)]
        public void TestIsValidEmail(string email, bool expected)
        {
            try
            {
                //Arrange
                //Act
                bool actual = UserEntries.IsValidEmail(email);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (UserEntriesException ex)
            {
                string actualMessage = ex.Message;
                string expectedMessage = "Enter Valid Email!";
                //Assert
                Assert.AreEqual(expectedMessage, actualMessage);
            }
        }

        [TestMethod]
        [DataRow("91 1234567890", true)]
        [DataRow("91-0123786789", false)]
        [DataRow("91 128895456871", false)]
        [DataRow("67 1000000000", true)]
        [DataRow("9876543210", false)]
        [DataRow("123 9874568584", false)]
        public void TestIsValidMobileNumber(string mobileNumber, bool expected)
        {
            try
            {
                //Arrange
                //Act
                bool actual = UserEntries.IsValidMobileNumber(mobileNumber);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (UserEntriesException ex)
            {
                string actualMessage = ex.Message;
                string expectedMessage = "Enter Valid Mobile Number!";
                //Assert
                Assert.AreEqual(expectedMessage, actualMessage);
            }
        }

        [TestMethod]
        [DataRow("Kirti@Swaraj11", true)]
        [DataRow("Kirti@Swaraj@123", false)]
        [DataRow("kirti@swaraj11", false)]
        [DataRow("Kirtiswaraj#18", true)]
        [DataRow("KirtiSwaraj11", false)]
        [DataRow("Kirti@Swaraj", false)]
        public void TestIsValidPassword(string password, bool expected)
        {
            try
            {
                //Arrange
                //Act
                bool actual = UserEntries.IsValidPassword(password);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (UserEntriesException ex)
            {
                string actualMessage = ex.Message;
                string expectedMessage = "Enter Valid Password!";
                //Assert
                Assert.AreEqual(expectedMessage, actualMessage);
            }
        }
    }
}