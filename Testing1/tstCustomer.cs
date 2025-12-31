using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{

    [TestClass]
    public class tstCustomer
    {
        string FullName = "Jainik Ratilal";
        string DateOfBirth = DateTime.Now.ToShortDateString();
        string Password = "Password123";
        string Email = "Jainikratilal@gmail.com";
        string Address = "DMU Road";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.Active = TestData;
            Assert.AreEqual(ACustomer.Active, TestData);
        }
        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateOfBirth = TestData;
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);
        }
        [TestMethod]
        public void FullNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "Jainik Ratilal";
            ACustomer.FullName = TestData;
            Assert.AreEqual(ACustomer.FullName, TestData);
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "jainikratilal@gmail.com";
            //assign the data to the property
            ACustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "EasyPassword99";
            //assign the data to the property
            ACustomer.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Password, TestData);
        }
        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "20 Jainik Street";
            //assign the data to the property
            ACustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerID = 197;
            Found = ACustomer.Find(CustomerID);
            Assert.IsTrue(Found);
        }
        //========================Find Method for Full Name======================================
        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an istance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 197;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check for the CustomerId
            if (ACustomer.CustomerId != 197)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        //========================Find Method for Full Name======================================

        [TestMethod]
        public void TestFullNameFound()
        {
            //create an istance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 197;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check for the FullName
            if (ACustomer.FullName != "Jainikkumar Ratilal")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        //========================Find Method for Date of Birth======================================
        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //create an istance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 197;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check for the DateOfBirth
            if (ACustomer.DateOfBirth != Convert.ToDateTime("17/03/2004"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        //========================Find Method for Address======================================
        [TestMethod]
        public void TestAddressFound()
        {
            //create an istance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 197;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check for the Address
            if (ACustomer.Address != "DMU University Road")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        //========================Find Method for Email======================================
        [TestMethod]
        public void TestEmailFound()
        {
            //create an istance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 197;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check for the Email
            if (ACustomer.Email != "Jainikratilal@gmail.com")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        //========================Find Method for Password=====================================
        [TestMethod]
        public void TestPasswordFound()
        {
            //create an istance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 197;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check for the Password
            if (ACustomer.Password != "Password123")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        //========================Find Method for Active======================================
        [TestMethod]
        public void TestActiveFound()
        {
            //create an istance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 197;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check for the Active
            if (ACustomer.Active != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        //========================Validation Method======================================

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            Error = ACustomer.Valid(this.FullName, this.Password, this.Email, this.Address, this.DateOfBirth);
            Assert.AreEqual(Error, "");
        }
        //========================Validation Method for FullName======================================
        [TestMethod]
        public void FullNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FullName = "a a";
            Error = ACustomer.Valid(FullName, this.Password,this.Email, this.Address, this.DateOfBirth);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FullName = "a";
            Error = ACustomer.Valid(FullName, this.Password, this.Email, this.Address, this.DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FullName = "aa a";
            Error = ACustomer.Valid(FullName, this.Password, this.Email, this.Address, this.DateOfBirth);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            FullName = FullName.PadRight(49, 'a');
            Error = ACustomer.Valid(FullName, this.Password, this.Email, this.Address, this.DateOfBirth);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(50, 'a');
            Error = ACustomer.Valid(FullName, this.Password, this.Email, this.Address, this.DateOfBirth);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(51, 'a');
            Error = ACustomer.Valid(FullName, this.Password, this.Email, this.Address, this.DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(25, 'a');
            Error = ACustomer.Valid(FullName, this.Password, this.Email, this.Address, this.DateOfBirth);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(100, 'a');
            Error = ACustomer.Valid(FullName, this.Password, this.Email, this.Address, this.DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }
        //===============================CustomerDateOfBirth======================================================================
        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date.AddYears(-100);
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1000);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(this.FullName, this.Password, this.Email, this.Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(this.FullName, this.Password, this.Email, this.Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(this.FullName, this.Password, this.Email, this.Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(this.FullName, this.Password, this.Email, this.Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(this.FullName, this.Password, this.Email, this.Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(this.FullName, this.Password, this.Email, this.Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(this.FullName, this.Password, this.Email, this.Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the Customer date of birth to todays date
            string DateOfBirth = "this is not a date!";
            //invoke the method
            Error = ACustomer.Valid(this.FullName, this.Password, this.Email, this.Address, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //=================================CustomerAddress========================================================================


        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Address = "";
            //invoke the method
            Error = ACustomer.Valid(this.FullName, this.Password, this.Email, Address, this.DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Address = "aa";
            //invoke the method
            Error = ACustomer.Valid(this.FullName, this.Password, this.Email, Address, this.DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AdressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Address = "";
            Address = Address.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(this.FullName, this.Password, this.Email, Address, this.DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Address = "";
            Address = Address.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(this.FullName, this.Password, this.Email, Address, this.DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Address = "";
            Address = Address.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(this.FullName, this.Password, this.Email, Address, this.DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Address = "";
            Address = Address.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = ACustomer.Valid(this.FullName, this.Password, this.Email, Address, this.DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        //================================================CustomerEmail============================================================

        [TestMethod]
        public void EmailMinLessOne()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass the method
            string Email = "@gmail.com"; // 7 characters, less than minimum
                                     // Invoke the method
            Error = ACustomer.Valid(FullName, Password, Email, Address, DateOfBirth);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass the method
            string Email = "a@gmail.com"; // 9 characters, minimum is 10
                                      // Invoke the method
            Error = ACustomer.Valid(FullName, Password, Email, Address, DateOfBirth);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass the method
            string Email = new string('a', 29) + "@gmail.com"; // 39 characters
                                                               // Invoke the method
            Error = ACustomer.Valid(FullName, Password, Email, Address, DateOfBirth);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass the method
            string Email = new string('a', 13) + "@gmail.com"; // 20 characters
                                                               // Invoke the method
            Error = ACustomer.Valid(FullName, Password, Email, Address, DateOfBirth);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass the method
            string Email = new string('a', 31) + "@gmail.com"; // 41 characters
                                                               // Invoke the method
            Error = ACustomer.Valid(FullName, Password, Email, Address, DateOfBirth);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass the method
            string Email = new string('a', 110) + "@gmail.com"; // 120 characters
                                                                // Invoke the method
            Error = ACustomer.Valid(FullName, Password, Email, Address, DateOfBirth);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailInvalidData()
        {
            // Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // String variable to store any error message
            String Error = "";
            // Set the Customer email to invalid data
            string Email = "this is not a email!";
            // Invoke the method
            Error = ACustomer.Valid(FullName, Password, Email, Address, DateOfBirth);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    //================================================Customer Password============================================================

    [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Password = "";
            Password = Password.PadRight(9, 'a');
            //invoke the method
            Error = ACustomer.Valid(this.FullName, Password, this.Email, this.Address, this.DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Password = "";
            Password = Password.PadRight(11, 'a');
            //invoke the method
            Error = ACustomer.Valid(this.FullName, Password, this.Email, this.Address, this.DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Password = "";
            Password = Password.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(this.FullName, Password, this.Email, this.Address, this.DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Password = "";
            Password = Password.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(this.FullName, Password, this.Email, this.Address, this.DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Password = "";
            Password = Password.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(this.FullName, Password, this.Email, this.Address, this.DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Password = "";
            Password = Password.PadRight(80, 'a');//this should fail
            //invoke the method
            Error = ACustomer.Valid(this.FullName, Password, this.Email, this.Address, this.DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
    }
}




