using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Testing5
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance
            clsStockCollection AllStock = new clsStockCollection();
            //test to see if it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create instance
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list objects
            List<clsStock> TestList = new List<clsStock>();
            //Add an item to the list
            //create item of the test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ArrivedOn = DateTime.Now;
            TestItem.StockId = 1;
            TestItem.ItemName = "TestName";
            TestItem.Available = true;
            TestItem.Price = 1000;
            TestItem.Quantity = 10;
            TestItem.SupplierId = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }


        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.ArrivedOn = DateTime.Now;
            TestStock.StockId = 1;
            TestStock.ItemName = "TestName";
            TestStock.Available = true;
            TestStock.Price = 1000;
            TestStock.Quantity = 10;
            TestStock.SupplierId = 1;
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //create test data
            //needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ArrivedOn = DateTime.Now;
            TestItem.StockId = 1;
            TestItem.ItemName = "TestName";
            TestItem.Available = true;
            TestItem.Price = 1000;
            TestItem.Quantity = 10;
            TestItem.SupplierId = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ArrivedOn = DateTime.Now;
            TestItem.ItemName = "TestName";
            TestItem.Available = true;
            TestItem.Price = 1000;
            TestItem.Quantity = 10;
            TestItem.SupplierId = 1;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key to the test data
            TestItem.StockId = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create instance
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable t store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ArrivedOn = DateTime.Now;
            TestItem.ItemName = "TestName123";
            TestItem.Available = true;
            TestItem.Price = 1000;
            TestItem.Quantity = 10;
            TestItem.SupplierId = 1;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.StockId = PrimaryKey;
            //modify the test record
            TestItem.ItemName = "NewName456";
            TestItem.Quantity = 0;
            TestItem.Available = false;
            //set the record based on the new test data
            AllStock.ThisStock = TestItem;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see if ThisStock matches the test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK() 
        {
            //create instance
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ArrivedOn = DateTime.Now;
            TestItem.ItemName = "SomeName123";
            TestItem.Available = true;
            TestItem.Price = 1000;
            TestItem.Quantity = 10;
            TestItem.SupplierId = 1;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.StockId = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStock.Delete();
            //now find the record
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByItemNameMethodOK()
        {
            //create instance
            clsStockCollection AllStock = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a blank string (should return all records)
            FilteredStock.ReportByItemName("");
            //test to see that the two values are teh same
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);   
        }

        [TestMethod]
        public void ReportByItemNameNoneFound()
        {
            //create instance
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a itemname that doesnt exist
            FilteredStock.ReportByItemName("ItemNameDoesNotExist");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByItemNameTestDataFound()
        {
            //create instance of filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a item name that doesnt exist
            FilteredStock.ReportByItemName("Filter1");
            //check that the correct number of records are found
            if (FilteredStock.Count == 2)
            {
                //check to see that the first record is 18
                if (FilteredStock.StockList[0].StockId != 18)
                {
                    OK = false;
                }
                //check to see that the first record is 19
                if (FilteredStock.StockList[1].StockId != 19)
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
