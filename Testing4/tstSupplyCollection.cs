using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstSupplyCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplyCollection AllSupplies = new clsSupplyCollection();    
            //test to see that is exists
            Assert.IsNotNull(AllSupplies); 
        }

        [TestMethod]
        public void SupplyListOK()
        {
            //create an instance of the class we want to create
            clsSupplyCollection AllSupplies = new clsSupplyCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsSupply> TestList = new List<clsSupply>();
            //Add an Item to the list
            //create the item of test data
            clsSupply TestItem = new clsSupply();
            //set its properties
            TestItem.SupplyID = 2;
            TestItem.SupplierContact = "p1234567@my365.dmu.ac.uk";
            TestItem.PriceOfResource = 1009;
            TestItem.DateRequested = DateTime.Now;
            TestItem.AvailabilityOfSupplier = true;
            TestItem.ToBeDeliveredBy = DateTime.Now;   
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllSupplies.SupplyList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSupplies.SupplyList, TestList);
        }
        
        [TestMethod]
        public void ThisSupplyPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplyCollection AllSupplies = new clsSupplyCollection();
            //create some test data to assign to the property
            clsSupply TestSupply = new clsSupply();
            //set the properties of the test object 
            TestSupply.SupplyID = 2;
            TestSupply.SupplierContact = "p1234567@my365.dmu.ac.uk";
            TestSupply.PriceOfResource = 1009;
            TestSupply.DateRequested = DateTime.Now;
            TestSupply.AvailabilityOfSupplier = true;
            TestSupply.ToBeDeliveredBy = DateTime.Now;
            //assign the data to the property
            AllSupplies.ThisSupply = TestSupply;
            //test to see that the two values are the same
            Assert.AreEqual(AllSupplies.ThisSupply, TestSupply);
        }
        
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsSupplyCollection AllSupplies = new clsSupplyCollection();
            //create some test data to assign to the property
            //the data needs to be a list of objects
            List<clsSupply> TestList = new List<clsSupply>();
            //Add an Item to the list 
            //create the item of the test data
            clsSupply TestItem = new clsSupply();
            //set its properties
            TestItem.SupplyID = 2;
            TestItem.SupplierContact = "p1234567@my365.dmu.ac.uk";
            TestItem.PriceOfResource = 1009;
            TestItem.DateRequested = DateTime.Now;
            TestItem.AvailabilityOfSupplier = true;
            TestItem.ToBeDeliveredBy = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllSupplies.SupplyList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSupplies.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplyCollection AllSupplies = new clsSupplyCollection();
            //create the item of test data
            clsSupply TestItem = new clsSupply();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.SupplyID = 2;
            TestItem.SupplierContact = "p3333333@my365.dmu.ac.uk";
            TestItem.PriceOfResource = 889;
            TestItem.DateRequested = DateTime.Now;
            TestItem.AvailabilityOfSupplier = true;
            TestItem.ToBeDeliveredBy = DateTime.Now;
            //set ThisSupply to the test data
            AllSupplies.ThisSupply = TestItem;
            //add the record
            PrimaryKey = AllSupplies.Add();
            //set the primary key of the test data
            TestItem.SupplyID = PrimaryKey;
            //find the record
            AllSupplies.ThisSupply.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllSupplies.ThisSupply, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplyCollection AllSupplies = new clsSupplyCollection();
            //create the item of test data
            clsSupply TestItem = new clsSupply();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.SupplierContact = "p1234567@my365.dmu.ac.uk";
            TestItem.PriceOfResource = 1009;
            TestItem.DateRequested = DateTime.Now;
            TestItem.AvailabilityOfSupplier = true;
            TestItem.ToBeDeliveredBy = DateTime.Now;
            //set ThisSupply to the test data
            AllSupplies.ThisSupply = TestItem;
            //add the record 
            PrimaryKey = AllSupplies.Add();
            //set the primary key of the test data
            TestItem.SupplyID = PrimaryKey;
            //modify the test record
            TestItem.SupplierContact = "p0010023@my365.dmu.ac.uk";
            TestItem.PriceOfResource = 45;
            TestItem.DateRequested = DateTime.Now;
            TestItem.AvailabilityOfSupplier = false;
            TestItem.ToBeDeliveredBy = DateTime.Now;
            //set the record based on the new test data
            AllSupplies.ThisSupply = TestItem;
            //update the record
            AllSupplies.Update();
            //find the record 
            AllSupplies.ThisSupply.Find(PrimaryKey);
            //test to see if ThisSupply matches the test data
            Assert.AreEqual(AllSupplies.ThisSupply, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplyCollection AllSupplies = new clsSupplyCollection();
            //create the item of test data
            clsSupply TestItem = new clsSupply();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.SupplyID = 2;
            TestItem.SupplierContact = "p1234567@my365.dmu.ac.uk";
            TestItem.PriceOfResource = 1009;
            TestItem.DateRequested = DateTime.Now;
            TestItem.AvailabilityOfSupplier = true;
            TestItem.ToBeDeliveredBy = DateTime.Now;
            //set ThisSupply to the test data
            AllSupplies.ThisSupply = TestItem;
            //add the record
            PrimaryKey = AllSupplies.Add();
            //set the primary key of the test data
            TestItem.SupplyID = PrimaryKey;
            //find the record
            AllSupplies.ThisSupply.Find(PrimaryKey);
            //delete the record
            AllSupplies.Delete();
            //now find the record
            Boolean Found = AllSupplies.ThisSupply.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportBySupplierContactOK()
        {
            //create an instance of the class containing unfiltered results
            clsSupplyCollection AllSupplies = new clsSupplyCollection();
            //create an instance of the filtered data
            clsSupplyCollection FilteredSupplies = new clsSupplyCollection();
            //apply a blank string (should return all records);
            FilteredSupplies.ReportBySupplierContact("");
            //test to see that the two values are the same
            Assert.AreEqual(AllSupplies.Count, FilteredSupplies.Count);
        }

        [TestMethod]
        public void ReportBySupplierContactNoneFound()
        {
            //create an instance of the class we want to create
            clsSupplyCollection FilteredSupplies = new clsSupplyCollection();
            //apply a Supplier Contact that doesn't exist
            FilteredSupplies.ReportBySupplierContact("abc def");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredSupplies.Count);
        }

        [TestMethod]
        public void ReportBySupplierContactTestDataFound()
        {
            //create an instance of the filtered data
            clsSupplyCollection FilteredSupplies = new clsSupplyCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a Supplier Contact that doesn't exist
            FilteredSupplies.ReportBySupplierContact("p1122556@my365.dmu.ac.uk");
            //check that the correct number of records are found
            if (FilteredSupplies.Count == 2)
            {
                //check to see that the first record is 52
                if (FilteredSupplies.SupplyList[0].SupplyID != 52)
                {
                    OK = false;
                }
                //check to seee that the first record is 53
                if (FilteredSupplies.SupplyList[1].SupplyID != 53)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
