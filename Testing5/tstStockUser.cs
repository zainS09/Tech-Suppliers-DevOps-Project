using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStockUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance
            clsStockUser User = new clsStockUser();
            //test it exists
            Assert.IsNotNull(User);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance 
            clsStockUser User = new clsStockUser();
            //create test data
            Int32 TestData = 1;
            //assign data to property
            User.UserID = TestData;
            //test to that that values match
            Assert.AreEqual(User.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance 
            clsStockUser User = new clsStockUser();
            //create test data
            string TestData = "Zain";
            //assign data to property
            User.UserName = TestData;
            //test to that that values match
            Assert.AreEqual(User.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance 
            clsStockUser User = new clsStockUser();
            //create test data
            string TestData = "password123";
            //assign data to property
            User.Password = TestData;
            //test to that that values match
            Assert.AreEqual(User.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance 
            clsStockUser User = new clsStockUser();
            //create test data
            string TestData = "Stock";
            //assign data to property
            User.Department = TestData;
            //test to that that values match
            Assert.AreEqual(User.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create instance
            clsStockUser User = new clsStockUser();
            //create a boolean var to store the results
            Boolean Found = false;
            //create test data to use with method
            string UserName = "Zain";
            string Password = "password123";
            //invoke method
            Found = User.FindUser(UserName, Password);      
            //test to see that the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create instance
            clsStockUser User = new clsStockUser();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK, assume it is
            Boolean OK = true;
            //create test data
            string UserName = "Zain";
            string Password = "password123";
            //invoke method
            Found = User.FindUser(UserName, Password);  
            //check the user id property
            if (User.UserName != UserName && User.Password != Password) 
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
