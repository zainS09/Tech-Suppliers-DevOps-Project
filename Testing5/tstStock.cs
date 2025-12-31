using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Dynamic;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {

        //good test data
        string ItemName = "Gigabyte GeForce RTX 4090 WindForce 24GB";
        string ArrivedOn = DateTime.Now.ToShortDateString();
        string Quantity = "19";
        string Price = "1699.99";
        string SupplierId = "1";


        /******************INSTANCE OF THE CLASS TEST******************/

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class to create
            clsStock StockItem = new clsStock();
            //test to see if it exists
            Assert.IsNotNull(StockItem);
        }

        /******************PROPERTY OK TESTS******************/

        [TestMethod]
        public void StockIdPropertyOK()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create some test data to assign to property
            int TestData = 1;
            //assign test data to property
            StockItem.StockId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StockItem.StockId, TestData);
        }

        [TestMethod]
        public void ArrivedOnPropertyOK()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create test data to assign to property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            StockItem.ArrivedOn = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StockItem.ArrivedOn, TestData);
        }

        [TestMethod]
        public void ItemNamePropertyOK()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create test data to assign to property
            string TestData = "GeForce GTX 1660";
            //assign the data to the property
            StockItem.ItemName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StockItem.ItemName, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create test data to assign to property
            int TestData = 5;
            //assign the data to the property
            StockItem.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StockItem.Quantity, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create test data to assign to property
            double TestData = 1699.99;
            //assign the data to the property
            StockItem.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StockItem.Price, TestData);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create test data to assign to property
            Boolean TestData = true;
            //assign the data to the property
            StockItem.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StockItem.Available, TestData);
        }

        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create test data to assign to property
            int TestData = 1;
            //assign the data to the property
            StockItem.SupplierId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StockItem.SupplierId, TestData);
        }

        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock StockItem = new clsStock();
            //create a boolean varaible to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StockId = 4;
            //invoke the method
            Found = StockItem.Find(StockId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/

        [TestMethod]
        public void TestStockIdFound()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 StockId = 4;
            //invoke the method
            Found = StockItem.Find(StockId);
            //check the stockId
            if (StockItem.StockId != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestArrivedOnFound()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 StockId = 4;
            //invoke the method
            Found = StockItem.Find(StockId);
            //check the arrived on property
            if (StockItem.ArrivedOn != Convert.ToDateTime("12/05/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemNameFound()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 StockId = 4;
            //invoke the method
            Found = StockItem.Find(StockId);
            //check the item name property
            if (StockItem.ItemName != "ASUS Radeon RX 7900 XTX 24GB")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 StockId = 4;
            //invoke the method
            Found = StockItem.Find(StockId);
            //check the quantity property
            if (StockItem.Quantity != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 StockId = 4;
            //invoke the method
            Found = StockItem.Find(StockId);
            //check the price property
            if (StockItem.Price != 979)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 StockId = 4;
            //invoke the method
            Found = StockItem.Find(StockId);
            //check the available property
            if (StockItem.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierIdFound()
        {
            //create an instance of the class
            clsStock StockItem = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 StockId = 4;
            //invoke the method
            Found = StockItem.Find(StockId);
            //check the supplier id property
            if (StockItem.SupplierId != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /******************VALID METHOD TESTS******************/

        [TestMethod]
        public void ValidMethodOK()
        {
            //create am instance of the class 
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        /******************PARAMETER TESTS (TEST LOG)******************/

        [TestMethod]
        public void ItemNameMinLessOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string ItemName = ""; //this should throw error
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //if there is an error the strings wont match
        }

        [TestMethod]
        public void ItemNameMin()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string ItemName = "a"; //this should pass
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMinPlusOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string ItemName = "aa"; //this should be ok
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxLessOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string ItemName = "";
            ItemName = ItemName.PadRight(69, 'a'); //this should pass
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMax()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string ItemName = "";
            ItemName = ItemName.PadRight(70, 'a'); //this should pass
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMid()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string ItemName = "";
            ItemName = ItemName.PadRight(35, 'a'); //this should pass
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxPlusOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string ItemName = "";
            ItemName = ItemName.PadRight(71, 'a'); //this should fail
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameExtremeMax()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string ItemName = "";
            ItemName = ItemName.PadRight(500, 'a'); //this should fail
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ArrivedOnExtremeMin()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //today's date minus 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string type
            string ArrivedOn = TestDate.ToString();
            //invoke the method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ArrivedOnMinLessOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //today's date minus 1 day
            TestDate = TestDate.AddDays(-1); //should cause error
            //convert the date variable to a string type
            string ArrivedOn = TestDate.ToString();
            //invoke the method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ArrivedOnMin()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string type
            string ArrivedOn = TestDate.ToString();
            //invoke the method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ArrivedOnMinPlusOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //today's date add 1 day
            TestDate = TestDate.AddDays(1); //should cause error
            //convert the date variable to a string type
            string ArrivedOn = TestDate.ToString();
            //invoke the method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ArrivedOnMax()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string type
            string ArrivedOn = TestDate.ToString();
            //invoke the method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ArrivedOnMaxPlusOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //today's date plus 1 day
            TestDate = TestDate.AddDays(1); //should cause error
            //convert the date variable to a string type
            string ArrivedOn = TestDate.ToString();
            //invoke the method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ArrivedOnExtremeMax()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //today's date plus 100 years
            TestDate = TestDate.AddYears(100); //should cause error
            //convert the date variable to a string type
            string ArrivedOn = TestDate.ToString();
            //invoke the method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ArrivedOnInvalidData()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //set arrived on to a invalid data type
            string ArrivedOn = "hello";
            //invoke the method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMin()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign an extreme min value
            TestInt = -999;
            //convert to string
            string Quantity = TestInt.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign a value of min (0) -1 
            TestInt = -1;
            //convert to string
            string Quantity = TestInt.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign the min value
            TestInt = 0;
            //convert to string
            string Quantity = TestInt.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign a value of min +1
            TestInt = 1;
            //convert to string
            string Quantity = TestInt.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign a value of max (200) -1
            TestInt = 199;
            //convert to string
            string Quantity = TestInt.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign the max value
            TestInt = 200;
            //convert to string
            string Quantity = TestInt.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign the max value +1
            TestInt = 201;
            //convert to string
            string Quantity = TestInt.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign the mid value 
            TestInt = 100;
            //convert to string
            string Quantity = TestInt.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp variable of type int
            int TestInt;
            //assign an extreme max value
            TestInt = 999;
            //convert to string
            string Quantity = TestInt.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInvalidData()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create a test variable that is not of type int
            double TestDouble;
            //assign a non int value
            TestDouble = 2.5;
            //convert to string
            string Quantity = TestDouble.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityBlank()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //leave the variable blank
            string Quantity = "";
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMin()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp price var
            double TestPrice;
            //assign extreme min value
            TestPrice = -99999.99;
            //add the temp var to test data
            Price = TestPrice.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp price var
            double TestPrice;
            //assign a value to var
            TestPrice = -1.10;
            //add the temp var to test data
            Price = TestPrice.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp price var
            double TestPrice;
            //assign a value to var
            TestPrice = 0.10;
            //add the temp var to test data
            Price = TestPrice.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp price var
            double TestPrice;
            //assign a value to var
            TestPrice = 1.10;
            //add the temp var to test data
            Price = TestPrice.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp price var
            double TestPrice;
            //assign a value to var
            TestPrice = 9999.00;
            //add the temp var to test data
            Price = TestPrice.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp price var
            double TestPrice;
            //assign a value to var
            TestPrice = 10000.00;
            //add the temp var to test data
            Price = TestPrice.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp price var
            double TestPrice;
            //assign a value to var
            TestPrice = 10001.00;
            //add the temp var to test data
            Price = TestPrice.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp price var
            double TestPrice;
            //assign a value to var
            TestPrice = 5000.00;
            //add the temp var to test data
            Price = TestPrice.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            //create temp price var
            double TestPrice;
            //assign a value to var
            TestPrice = 99999.99;
            //add the temp var to test data
            Price = TestPrice.ToString();
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string c=variable to store error message
            String Error = "";
            string Price = "hello";
            //invoke method
            Error = StockItem.Valid(ItemName, ArrivedOn, Quantity, Price, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


    }
}
