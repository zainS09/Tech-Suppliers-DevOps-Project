using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingStaff
{
    [TestClass]
    public class tstStaff
    {

        // Create good test data
        string GoodStaffId = "100";
        string GoodName = "John Doe";
        string GoodEmail = "john.doe@example.com";
        string GoodRole = "Developer";
        string GoodDateHired = DateTime.Now.ToShortDateString();
        string GoodIsActive = "true";
        string GoodHourlyRate = "25.50";
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            string TestData = "John Doe";
            // assign the data to the property
            AStaff.Name = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AStaff.Name, TestData);
        }

        [TestMethod]
        public void StaffEmailPropertyOK()
        {
            // similar setup as StaffNamePropertyOK
            clsStaff AStaff = new clsStaff();
            string TestData = "johndoe@example.com";
            AStaff.StaffEmail = TestData;
            Assert.AreEqual(AStaff.StaffEmail, TestData);
        }

        [TestMethod]
        public void StaffRolePropertyOK()
        {
            // similar setup as StaffNamePropertyOK
            clsStaff AStaff = new clsStaff();
            string TestData = "Manager";
            AStaff.Role = TestData;
            Assert.AreEqual(AStaff.Role, TestData);
        }

        [TestMethod]
        public void DateHiredPropertyOK()
        {
            // similar setup as StaffNamePropertyOK
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AStaff.DateHired = TestData;
            Assert.AreEqual(AStaff.DateHired, TestData);
        }

        [TestMethod]
        public void IsActivePropertyOK()
        {
            // similar setup as StaffNamePropertyOK
            clsStaff AStaff = new clsStaff();
            bool TestData = true;
            AStaff.Active = TestData;
            Assert.AreEqual(AStaff.Active, TestData);
        }

        [TestMethod]
        public void HourlyRatePropertyOK()
        {
            // similar setup as StaffNamePropertyOK
            clsStaff AStaff = new clsStaff();
            decimal TestData = 15.75m;
            AStaff.HourlyRate = TestData;
            Assert.AreEqual(AStaff.HourlyRate, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffId = 9;  // Changed from 21 to 8
            Found = aStaff.Find(StaffId);
            Assert.IsTrue(Found, "Error: The staff member could not be found.");
        }

        [TestMethod]
        public void TestStaffIdIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 9;  // Changed from 21 to 8
            Found = aStaff.Find(StaffId);
            if (aStaff.StaffId != 9) { OK = false; }  // Changed from 21 to 8
            Assert.IsTrue(OK, "Staff ID not found correctly.");
        }

        [TestMethod]
        public void TestNameIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = aStaff.Find(9);  // Changed from 21 to 8
            if (aStaff.Name != "issam") { OK = false; }
            Assert.IsTrue(OK, "Name not found correctly.");
        }

        [TestMethod]
        public void TestRoleIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = aStaff.Find(9);  // Changed from 21 to 8
            if (aStaff.Role != "shpping ") { OK = false; }
            Assert.IsTrue(OK, "Role not found correctly.");
        }

        [TestMethod]
        public void TestDateHiredIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = aStaff.Find(9);  // Changed from 21 to 8
            if (aStaff.DateHired != Convert.ToDateTime("2020-03-09")) { OK = false; }
            Assert.IsTrue(OK, "Date Hired not found correctly.");
        }

        [TestMethod]
        public void TestActiveIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = aStaff.Find(9);  // Changed from 21 to 8
            if (!aStaff.Active) { OK = false; }
            Assert.IsTrue(OK, "Active status not found correctly.");
        }

        [TestMethod]
        public void TestHourlyRateIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = aStaff.Find(9);  // Changed from 21 to 8
            if (aStaff.HourlyRate != 15.00m) { OK = false; }
            Assert.IsTrue(OK, "Hourly rate not found correctly.");
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            // Create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            // String variable to store any error message
            string Error = "";
            // Invoke the method
            Error = aStaff.Valid(GoodName, GoodEmail, GoodRole, GoodDateHired, GoodIsActive, GoodHourlyRate);
            // Test to see that the result is correct
            Assert.AreEqual("", Error, "Validation failed when it should have passed.");
        }

        // Name validation tests
        [TestMethod]
        public void NameMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Error = aStaff.Valid( Name, GoodEmail, GoodRole, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void NameMin()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Name = "a";
            Error = aStaff.Valid(Name, GoodEmail, GoodRole, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Name = "aa";
            Error = aStaff.Valid(Name, GoodEmail, GoodRole, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Name = new string('a', 254);
            Error = aStaff.Valid(Name, GoodEmail, GoodRole, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void NameMax()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Name = new string('a', 255);
            Error = aStaff.Valid(Name, GoodEmail, GoodRole, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Name = new string('a', 256);
            Error = aStaff.Valid(Name, GoodEmail, GoodRole, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Name = new string('a', 500);
            Error = aStaff.Valid(Name, GoodEmail, GoodRole, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreNotEqual("", Error);
        }

        // Email validation tests
        [TestMethod]
        public void EmailMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Email = "";
            Error = aStaff.Valid(GoodName, Email, GoodRole, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void EmailMin()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Email = "a";
            Error = aStaff.Valid(GoodName, Email, GoodRole, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Email = "aa";
            Error = aStaff.Valid( GoodName, Email, GoodRole, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Email = new string('a', 254);
            Error = aStaff.Valid( GoodName, Email, GoodRole, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void EmailMax()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Email = new string('a', 255);
            Error = aStaff.Valid( GoodName, Email, GoodRole, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Email = new string('a', 256);
            Error = aStaff.Valid( GoodName, Email, GoodRole, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Email = new string('a', 500);
            Error = aStaff.Valid(GoodName, Email, GoodRole, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreNotEqual("", Error);
        }

        // Role validation tests
        [TestMethod]
        public void RoleMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Role = "";
            Error = aStaff.Valid(  GoodName, GoodEmail, Role, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void RoleMin()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Role = "a";
            Error = aStaff.Valid(    GoodName, GoodEmail, Role, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void RoleMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Role = "aa";
            Error = aStaff.Valid(GoodName, GoodEmail, Role, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void RoleMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Role = new string('a', 254);
            Error = aStaff.Valid( GoodName, GoodEmail, Role, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void RoleMax()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Role = new string('a', 255);
            Error = aStaff.Valid(GoodName, GoodEmail, Role, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void RoleMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Role = new string('a', 256);
            Error = aStaff.Valid(GoodName, GoodEmail, Role, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void RoleExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Role = new string('a', 500);
            Error = aStaff.Valid( GoodName, GoodEmail, Role, GoodDateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreNotEqual("", Error);
        }

        // DateHired validation tests
        [TestMethod]
        public void DateHiredExtremeMin()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateHired = TestDate.ToString();
            Error = aStaff.Valid(GoodName, GoodEmail, GoodRole, DateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void DateHiredMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateHired = TestDate.ToString();
            Error = aStaff.Valid(GoodName, GoodEmail, GoodRole, DateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void DateHiredMin()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateHired = TestDate.ToString();
            Error = aStaff.Valid(GoodName, GoodEmail, GoodRole, DateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void DateHiredMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateHired = TestDate.ToString();
            Error = aStaff.Valid(GoodName, GoodEmail, GoodRole, DateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void DateHiredExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateHired = TestDate.ToString();
            Error = aStaff.Valid(GoodName, GoodEmail, GoodRole, DateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void DateHiredInvalidData()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string DateHired = "this is not a date!";
            Error = aStaff.Valid( GoodName, GoodEmail, GoodRole, DateHired, GoodIsActive, GoodHourlyRate);
            Assert.AreNotEqual("", Error);
        }

        // HourlyRate validation tests
        [TestMethod]
        public void HourlyRateMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string HourlyRate = "-1";
            Error = aStaff.Valid( GoodName, GoodEmail, GoodRole, GoodDateHired, GoodIsActive, HourlyRate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void HourlyRateMin()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string HourlyRate = "0";
            Error = aStaff.Valid( GoodName, GoodEmail, GoodRole, GoodDateHired, GoodIsActive, HourlyRate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void HourlyRateMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string HourlyRate = "1";
            Error = aStaff.Valid( GoodName, GoodEmail, GoodRole, GoodDateHired, GoodIsActive, HourlyRate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void HourlyRateInvalidData()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string HourlyRate = "this is not a number!";
            Error = aStaff.Valid( GoodName, GoodEmail, GoodRole, GoodDateHired, GoodIsActive, HourlyRate);
            Assert.AreNotEqual("", Error);
        }
    }
}
