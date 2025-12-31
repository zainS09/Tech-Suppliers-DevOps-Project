using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupplyUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplyUser AUser = new clsSupplyUser();
            //test to see that it exists
            Assert.IsNotNull(AUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplyUser AUser = new clsSupplyUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AUser.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplyUser AUser = new clsSupplyUser();
            //create some test data to assign to the property
            string TestData = "Sarvarbek";
            //assign the data to the property
            AUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplyUser AUser = new clsSupplyUser();
            //create some test data to assign to the property
            string TestData = "stats123";
            //assign the data to the property
            AUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplyUser AUser = new clsSupplyUser();
            //create some test data to assign to the property
            string TestData = "Supply Management";
            //assign the data to the property
            AUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplyUser AUser = new clsSupplyUser();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Sarvarbek";
            string Password = "stats123";
            //invoke the method
            Found = AUser.FindUser(UserName, Password); 
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class we want to create
            clsSupplyUser AUser = new clsSupplyUser();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string UserName = "Sarvarbek";
            string Password = "stats123";
            //invoke the method
            Found = AUser.FindUser(UserName, Password);
            //check the User ID property
            if (AUser.UserName != UserName && AUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
