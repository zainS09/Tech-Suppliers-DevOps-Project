using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        string ShippingAdress = "Dmu";
        string PaymentMethod = "visa";
        string Order_Arrival = "true";
        string OrderDate = "2024-05-04";
        [TestMethod]
        public void InstanceOk()
        {
            //create the instance 
            clsOrder AnOrder = new clsOrder();
            // test the existence 
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void OrderArrival()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.Order_Arrival = TestData;
            Assert.AreEqual(AnOrder.Order_Arrival, TestData);
        }
        [TestMethod]
        public void DateOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }
        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }
        [TestMethod]
        public void ShippingAdressPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "2 Boulevard Street";
            //assign the data to the property
            AnOrder.ShippingAdress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ShippingAdress, TestData);
        }
        [TestMethod]
        public void PaymentMethodPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Master Card";
            //assign the data to the property
            AnOrder.PaymentMethod = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.PaymentMethod, TestData);
        }
        [TestMethod]

        public void StockIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.StockID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.StockID, TestData);
        }
        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an istance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1059;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check for the CustomerId
            if (AnOrder.OrderId
               == 1)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK, "Order id not found");
        }
        [TestMethod]
        public void TestShippingAdressIsFound()
        {
            clsOrder Anorder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Found = Anorder.Find(1059);  // Changed from 21 to 8
            if (Anorder.ShippingAdress != "DMU Road 234") { OK = false; }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPaymentMethodIsFound()
        {
            clsOrder Anorder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Found = Anorder.Find(1059);  // Changed from 21 to 8
            if (Anorder.PaymentMethod != "visa") { OK = false; }
            Assert.IsTrue(OK, "Role not found correctly.");
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            // Create an instance of the class we want to create
            clsOrder Anorder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // Invoke the method
            Error = Anorder.Valid(this.ShippingAdress, this.PaymentMethod, this.OrderDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestArrivalFound()
        {
            //create an istance of the class we want to create
            clsOrder Anorder = new clsOrder();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1059;
            //invoke the method
            Found = Anorder.Find(OrderID);
            //check for the Active
            if (Anorder.Order_Arrival != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AdressMinLessOne()
        {
            clsOrder aOrder = new clsOrder();
            string Error = "";
            string adress = "";
            Error = aOrder.Valid(adress, PaymentMethod, OrderDate);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void AdressMin()
        {
            clsOrder aOrder = new clsOrder();
            string Error = "";
            string adress = "a";
            Error = aOrder.Valid(adress, PaymentMethod, OrderDate);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void AdressMinPlusOne()
        {
            clsOrder aOrder = new clsOrder();
            string Error = "";
            string adress = "aa";
            Error = aOrder.Valid(adress, PaymentMethod, OrderDate);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void AdressMaxLessOne()
        {
            clsOrder aOrder = new clsOrder();
            string Error = "";
            string adress = new string('a', 199);
            Error = aOrder.Valid(adress, PaymentMethod, OrderDate);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void AdressMax()
        {
            clsOrder aOrder = new clsOrder();
            string Error = "";
            string adress = new string('a', 200);
            Error = aOrder.Valid( adress,PaymentMethod,OrderDate);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void AdressMaxPlusOne()
        {
            clsOrder aOrder = new clsOrder();
            string Error = "";
            string adress = new string('a', 201);
            Error = aOrder.Valid(adress, PaymentMethod, OrderDate);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void AdressExtremeMax()
        {
            clsOrder aOrder = new clsOrder();
            string Error = "";
            string adress = new string('a', 500);
            Error = aOrder.Valid(adress, PaymentMethod, OrderDate);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrder aOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = aOrder.Valid(ShippingAdress, PaymentMethod, OrderDate);
            Assert.AreEqual("", Error);
        }
        [TestMethod]    
        public void OrderDateMinLessOne()
        {
            clsOrder aOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDate = TestDate.ToString();
            Error = aOrder.Valid(ShippingAdress, PaymentMethod, OrderDate);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void OrderDateMin()
        {
            clsOrder aOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = aOrder.Valid(ShippingAdress, PaymentMethod, OrderDate);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrder aOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string OrderDate = TestDate.ToString();
            Error = aOrder.Valid(ShippingAdress, PaymentMethod, OrderDate);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrder aOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string OrderDate = TestDate.ToString();
            Error = aOrder.Valid(ShippingAdress, PaymentMethod, OrderDate);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void OrderDateInvalidData()
        {
            clsOrder aOrder = new clsOrder();
            string Error = "";
            string OrderDate = "this is not a date!";
            Error = aOrder.Valid(ShippingAdress, PaymentMethod, OrderDate);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void MethodRequiredPaypal()
        {
            clsOrder aOrder=new clsOrder();
            string Error = "";
            string PaymentMethod = "paypal";
            Error = aOrder.Valid(ShippingAdress, PaymentMethod,OrderDate);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void MethodRequiredMasterCrd2() {
            clsOrder aOrder = new clsOrder();
            string Error = "";
            string PaymentMethod = "master card";
            Error = aOrder.Valid(ShippingAdress, PaymentMethod, OrderDate);
            Assert.AreEqual("", Error);

        }
        [TestMethod]
        public void MethodRequiredVisa3() {
            clsOrder aOrder = new clsOrder();
            string Error = "";
            string PaymentMethod = "visa";
            Error = aOrder.Valid(ShippingAdress, PaymentMethod, OrderDate);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void DifferentMethod()
        {
            clsOrder aOrder = new clsOrder();
            string Error = "";
            string PaymentMethod = "venmo";
            Error = aOrder.Valid(ShippingAdress, PaymentMethod, OrderDate);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void BlankMethod() {
            clsOrder aOrder = new clsOrder();
            string Error = "";
            string PaymentMethod = "";
            Error = aOrder.Valid(ShippingAdress, PaymentMethod, OrderDate);
            Assert.AreNotEqual("", Error);
        }
       

    }
}
