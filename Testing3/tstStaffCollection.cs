using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // test to see that it exists
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create some test data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            // add an item to the list
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // set its properties
            TestItem.StaffId = 1;
            TestItem.Name = "John Doe";
            TestItem.StaffEmail = "john.doe@example.com";
            TestItem.Role = "Manager";
            TestItem.DateHired = DateTime.Now.Date;
            TestItem.HourlyRate = 25.50m;
            TestItem.Active = true;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllStaff.StaffList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
      
       

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            // set the properties of the test object
            TestStaff.StaffId = 1;
            TestStaff.Name = "John Doe";
            TestStaff.StaffEmail = "john.doe@example.com";
            TestStaff.Role = "Manager";
            TestStaff.DateHired = DateTime.Now.Date;
            TestStaff.HourlyRate = 25.50m;
            TestStaff.Active = true;
            // assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            // test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
       
        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            // add an item to the list
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // set its properties
            TestItem.StaffId = 1;
            TestItem.Name = "John marr Doe";
            TestItem.StaffEmail = "john.dvsa.dvsdoe@example.com";
            TestItem.Role = "Managers";
            TestItem.DateHired = DateTime.Now.Date;
            TestItem.HourlyRate = 25.50m;
            TestItem.Active = true;
            // add the item to the test list
            TestList.Add(TestItem);

            // create another item of test data
            TestItem = new clsStaff();
            // set its properties
            TestItem.StaffId = 2;
            TestItem.Name = "Jane Smith";
            TestItem.StaffEmail = "jane.smith@example.com";
            TestItem.Role = "Assistant";
            TestItem.DateHired = DateTime.Now.Date;
            TestItem.HourlyRate = 20.00m;
            TestItem.Active = true;
            // add the item to the test list
            TestList.Add(TestItem);

            // assign the data to the property
            AllStaff.StaffList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.StaffId = 1;
            TestItem.Name = "John stive Doe";
            TestItem.StaffEmail = "john.S.doe@example.com";
            TestItem.Role = "Manager";
            TestItem.DateHired = DateTime.Now.Date;
            TestItem.HourlyRate = 25.50m;
            TestItem.Active = true;
            // set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            // add the record
            PrimaryKey = AllStaff.Add();
            // set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            // find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.Name    = "John you Doe";
            TestItem.StaffEmail = "john.you.doe@example.com";
            TestItem.Role = "Manager";
            TestItem.DateHired = DateTime.Now.Date;
            TestItem.HourlyRate = 25.50m;
            TestItem.Active = true;
            // set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            // add the record
            PrimaryKey = AllStaff.Add();
            // set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            // modify the test record
            TestItem.Name = "Jane Moh Doe";
            TestItem.StaffEmail = "jane.moh.doe@example.com";
            TestItem.Role = "Senior Manager";
            TestItem.DateHired = DateTime.Now.Date.AddDays(-1); // assuming the date hired is the previous day
            TestItem.HourlyRate = 30.00m;
            TestItem.Active = false;
            // set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            // update the record
            AllStaff.Update();
            // find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            // test to see if ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.Name = "John chris Doe";
            TestItem.StaffEmail = "john.chris.doe@example.com";
            TestItem.Role = "Manager";
            TestItem.DateHired = DateTime.Now.Date;
            TestItem.HourlyRate = 25.50m;
            TestItem.Active = true;
            // set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            // add the record
            PrimaryKey = AllStaff.Add();
            // set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            // find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            // delete the record
            AllStaff.Delete();
            // now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            // test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByRoleMethodOK()
        {
            // create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            // apply a blank string (should return all records)
            FilteredStaff.ReportByRole("");
            // test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }
        [TestMethod]
        public void ReportByRoleNoneFound()
        {
            // create an instance of the class we want to create
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            // apply a role that doesn't exist
            FilteredStaff.ReportByRole("NonExistentRole");
            // test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }
        [TestMethod]
        public void ReportByRoleTestDataFound()
        {
            // Create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            // Variable to store the outcome
            Boolean OK = true;
            // Apply a role that doesn't exist
            FilteredStaff.ReportByRole("IT staff");
            // Check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                // Check to see that the first record is 8
                if (FilteredStaff.StaffList[0].StaffId != 8)
                {
                    OK = false;
                }
                // Check to see that the second record is 1151
                if (FilteredStaff.StaffList[1].StaffId != 1151)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            // Test to see that there are no records
            Assert.IsTrue(OK);
        }


    }
}
