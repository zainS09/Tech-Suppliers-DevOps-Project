using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomerUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerUser AUser = new clsCustomerUser();
            Assert.IsNotNull(AUser);    
        }
        [TestMethod]
        public void UserIdPropertyOK()
        {
            clsCustomerUser AUser = new clsCustomerUser();
            Int32 TestData = 1;
            AUser.UserID = TestData;
            Assert.AreEqual(AUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK() 
        {
            clsCustomerUser AUser = new clsCustomerUser();
            string TestData = "Jainik";
            AUser.UserName = TestData;
            Assert.AreEqual(AUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsCustomerUser AUser = new clsCustomerUser();
            string TestData = "Password123";
            AUser.Password = TestData;
            Assert.AreEqual(AUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsCustomerUser AUser = new clsCustomerUser();
            string TestData = "Customer";
            AUser.Department = TestData;
            Assert.AreEqual(AUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            clsCustomerUser AUser = new clsCustomerUser();
            Boolean Found = false;
            string UserName = "Jainik";
            string Password = "Password123";
            Found = AUser.FindUser(UserName, Password); 
            Assert.IsTrue(Found);   
        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsCustomerUser AUser = new clsCustomerUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Jainik";
            string Password = "Password123";
            Found = AUser.FindUser(UserName, Password);
            if (AUser.UserName != UserName && AUser.Password != Password) 
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
    }
}
