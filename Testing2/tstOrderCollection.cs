using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace Testing2
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsOrderCollection AllOrderAdress = new clsOrderCollection();
            Assert.IsNotNull(AllOrderAdress);
        }
        [TestMethod]
        public void OrderListOK()
        {
            // create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create some test data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            // add an item to the list
            // create the item of test data
            clsOrder TestItem = new clsOrder();
            // set its properties
            TestItem.OrderId = 1059;
            TestItem.ShippingAdress = "DMU ROAD 234";
            TestItem.PaymentMethod = "visa";        
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Order_Arrival = true;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllOrders.OrderList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);

        }
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create some test data to assign to the property
            clsOrder TestOrder= new clsOrder();
            // set the properties of the test object
            TestOrder.OrderId = 1059;
            TestOrder.ShippingAdress = "DMU ROAD 234";
            TestOrder.PaymentMethod = "visa";
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.Order_Arrival = true;
            // assign the data to the property
            AllOrders.ThisOrder= TestOrder;
            // test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            // create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            // create the item of test data
            clsOrder TestItem = new clsOrder();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.OrderId = 1059;
            TestItem.ShippingAdress = "DMU ROAD 234";
            TestItem.PaymentMethod = "visa";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Order_Arrival = true;
            // set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            // add the record
            PrimaryKey = AllOrder.Add();
            // set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            // find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            // create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            // create the item of test data
            clsOrder TestItem = new clsOrder();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.OrderId = 1059;
            TestItem.ShippingAdress = "DMU ROAD 234";
            TestItem.PaymentMethod = "visa";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Order_Arrival = true;
            // set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            // add the record
            PrimaryKey = AllOrder.Add();
            // set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            // modify the test record
            
            TestItem.ShippingAdress = "DMU ROAD 2345";
            TestItem.PaymentMethod = "paypal";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Order_Arrival = false;
            // set the record based on the new test data
            AllOrder.ThisOrder = TestItem;
            // update the record
            AllOrder.Update();
            // find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            // test to see if ThisOrder matches the test data
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            // create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            // create the item of test data
            clsOrder TestItem = new clsOrder();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.OrderId = 1059;
            TestItem.ShippingAdress = "DMU ROAD 234";
            TestItem.PaymentMethod = "visa";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Order_Arrival = true;
            // set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            // add the record
            PrimaryKey = AllOrder.Add();
            // set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            // find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            // delete the record
            AllOrder.Delete();
            // now find the record
            Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);
            // test to see that the record was not found
            Assert.IsFalse(Found);
        }
    }
}
