using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupply
    {
        //good test data
        //create some test data to pass the method
        string SupplierContact = "p1122334@my365.dmu.ac.uk";
        string PriceOfResource = "1322.15";
        string DateRequested = DateTime.Now.ToShortDateString();
        string ToBeDeliveredBy = DateTime.Now.ToShortDateString();


        /*************************INSTANCE OF THE CLASS TEST**************************/

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //test to see that it exists
            Assert.IsNotNull(ASupply);
        }
        /*************************PROPERTY OK TESTS***********************************/

        [TestMethod]
        public void AvailabilityOfSupplierPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ASupply.AvailabilityOfSupplier = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupply.AvailabilityOfSupplier, TestData);
        }
        [TestMethod]
        public void DateRequestedPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ASupply.DateRequested = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupply.DateRequested, TestData);
        }
        [TestMethod]
        public void ToBeDeliveredByPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ASupply.ToBeDeliveredBy = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupply.ToBeDeliveredBy, TestData);
        }
        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ASupply.SupplyID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupply.SupplyID, TestData);
        }
        [TestMethod]
        public void SupplierContactPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create some test data to assign to the property
            string TestData = "p2709563@my365.dmu.ac.uk";
            //assign the data to the property
            ASupply.SupplierContact = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupply.SupplierContact, TestData);
        }
        [TestMethod]
        public void PriceOfResourcePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create some test data to assign to the property
            double TestData = 1699.99;
            //assign the data to the property
            ASupply.PriceOfResource = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupply.PriceOfResource, TestData);
        }

        /*************************FIND METHOD TEST**********************************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsSupply ASupply = new clsSupply();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 SupplyID = 5;
            //invoke the method
            Found = ASupply.Find(SupplyID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /*************************PROPERTY DATA TEST FOR SUPPLY ID*******************************/

        [TestMethod]
        public void TestSupplyIDFound()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplyID = 5;
            //invoke the method
            Found = ASupply.Find(SupplyID);
            //check the Supply ID
            if (ASupply.SupplyID != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /*************************PROPERTY DATA TEST FOR SUPPLIER CONTACT*******************************/

        [TestMethod]
        public void TestSupplierContactFound()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assime it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplyID = 5;
            //invoke the method
            Found = ASupply.Find(SupplyID);
            //check the Supplier Contact property
            if (ASupply.SupplierContact != "p1122334@my365.dmu.ac.uk")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /*************************PROPERTY DATA TEST FOR PRICE OF RESOURCE*******************************/

        [TestMethod]
        public void TestPriceOfResourceFound()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplyID = 5;
            //invoke the method
            Found= ASupply.Find(SupplyID);
            //check the Price Of Resource property
            if (ASupply.PriceOfResource != Convert.ToDouble(1322.15))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /*************************PROPERTY DATA TEST FOR DATE REQUESTED*******************************/

        [TestMethod]
        public void TestDateRequestedFound()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplyID = 5;
            //invoke the method
            Found = ASupply.Find(SupplyID);
            //check the Date Requested property
            if (ASupply.DateRequested != Convert.ToDateTime("10/03/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /*************************PROPERTY DATA TEST FOR AVAILABILITY OF SUPPLIER*******************************/

        [TestMethod]
        public void TestAvailabilityOfSupplierFound()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplyID = 5;
            //invoke the method 
            Found = ASupply.Find(SupplyID);
            //check the Availability Of Supplier property
            if (ASupply.AvailabilityOfSupplier != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /*************************PROPERTY DATA TEST FOR TO BE DELIVERED BY*******************************/

        [TestMethod]
        public void TestToBeDeliveredByFound()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplyID = 5;
            //invoke the method
            Found = ASupply.Find(SupplyID);
            //check the To Be Delivered By property
            if (ASupply.ToBeDeliveredBy != Convert.ToDateTime("15/06/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        /*****************************VALID METHOD TEST********************************************/

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /********************************SUPPLIER CONTACT MIN LESS ONE TEST******************************************/

        [TestMethod]
        public void SupplierContactMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierContact = ""; //this should trigger an error
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /*********************************SUPPLIER CONTACT MIN TEST***********************************************/

        [TestMethod]
        public void SupplierContactMin()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string SupplierContact = "p"; //this should be OK
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /******************************SUPPLIER CONTACT MIN PLUS ONE************************************************/

        [TestMethod]
        public void SupplierContactMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierContact = "p2"; //this should be OK
            //invoke the method 
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*****************************SUPPLIER CONTACT MAX LESS ONE*************************************************/

        [TestMethod]
        public void SupplierContactMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string SupplierContact = "";
            SupplierContact = SupplierContact.PadRight(49, 'p');
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /***************************SUPPLIER CONTACT MAX*************************************************************/

        [TestMethod]
        public void SupplierContactMax()
        {
            //create an instance of the class we want to create 
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string SupplierContact = "";
            SupplierContact = SupplierContact.PadRight(50, 'p'); //this should be OK
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*****************************SUPPLIER CONTACT MAX PLUS ONE********************************************/

        [TestMethod]
        public void SupplierContactMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string SupplierContact = ""; //this should fail
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /*****************************SUPPLIER CONTACT MID*****************************************************/

        [TestMethod]
        public void SupplierContactMid()
        {
            //create an instance of the class we want to create 
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string SupplierContact = "";
            SupplierContact = SupplierContact.PadRight(25, 'p'); //this should be OK
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*****************************SUPPLIER EXTREME MAX*****************************************************/

        [TestMethod]
        public void SupplierContactExtremeMax()
        {
            //create an instance of the class we want to create 
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string SupplierContact = "";
            SupplierContact = SupplierContact.PadRight(500, 'p'); //this should fail
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /*****************************DATE REQUESTED EXTREME MIN*****************************************************/

        [TestMethod]
        public void DateRequestedExtremeMin()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateRequested = TestDate.ToString();
            //invoke the method 
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /*****************************DATE REQUESTED MIN LESS ONE*****************************************************/

        [TestMethod]
        public void DateRequestedMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateRequested = TestDate.ToString();
            //invoke the method 
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /*****************************DATE REQUESTED MIN *****************************************************/

        [TestMethod]
        public void DateRequestedMin()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateRequested = TestDate.ToString();
            //invoke the method 
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*****************************DATE REQUESTED MIN PLUS ONE *****************************************************/

        [TestMethod]
        public void DateRequestedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateRequested = TestDate.ToString();
            //invoke the method 
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /*****************************DATE REQUESTED EXTREME MAX *****************************************************/

        [TestMethod]
        public void DateRequestedExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateRequested = TestDate.ToString();
            //invoke the method 
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /*****************************DATE REQUESTED INVALID DATA *****************************************************/

        [TestMethod]
        public void DateRequestedInvalidData()
        {
            //create an instance of the class we want to create 
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //set the DateRequested to a non date value
            string DateRequested = "This is not a date!";
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
        }
        /*****************************TO BE DELIVERED BY EXTREME MIN *****************************************************/

        [TestMethod]
        public void ToBeDeliveredByExtremeMin()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todats date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable 
            string ToBeDeliveredBy = TestDate.ToString();
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*****************************TO BE DELIVERED BY MIN LESS ONE *****************************************************/

        [TestMethod]
        public void ToBeDeliveredByMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todats date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable 
            string ToBeDeliveredBy = TestDate.ToString();
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*****************************TO BE DELIVERED BY MIN **********************************************************/

        [TestMethod]
        public void ToBeDeliveredByMin()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todats date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string ToBeDeliveredBy = TestDate.ToString();
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*****************************TO BE DELIVERED BY MIN PLUS ONE **********************************************************/

        [TestMethod]
        public void ToBeDeliveredByMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todats date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1); 
            //convert the date variable to a string variable 
            string ToBeDeliveredBy = TestDate.ToString();
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*****************************TO BE DELIVERED BY EXTREME MAX **********************************************************/

        [TestMethod]
        public void ToBeDeliveredByExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todats date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 day
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable 
            string ToBeDeliveredBy = TestDate.ToString();
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*****************************PRICE OF RESOURCE EXTREME MIN **********************************************************/

        [TestMethod]
        public void PriceOfResourceExtremeMin()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create temp PriceOfResource variable
            double TestPrice;
            //assign extreme min value
            TestPrice = -999.99;
            //add the temp var to test data
            PriceOfResource = TestPrice.ToString();
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /*****************************PRICE OF RESOURCE MIN  **********************************************************/

       [TestMethod]
       public void PriceOfResourceMin()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create temp price variable
            double TestPrice;
            //assign extreme min value
            TestPrice = 1.0;
            //add the temp var to test data
            PriceOfResource = TestPrice.ToString();
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*****************************PRICE OF RESOURCE MIN PLUS ONE  **********************************************************/

        [TestMethod]
        public void PriceOfResourceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create temp price variable
            double TestPrice;
            //assign extreme min value
            TestPrice = 11.0;
            //add the temp var to test data
            PriceOfResource = TestPrice.ToString();
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*****************************PRICE OF RESOURCE MAX LESS ONE  **********************************************************/

        [TestMethod]
        public void PriceOfResourceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create temp price variable
            double TestPrice;
            //assign extreme min value
            TestPrice = 1.0;
            PriceOfResource = TestPrice.ToString().PadRight(52);
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*****************************PRICE OF RESOURCE MAX   **********************************************************/

        [TestMethod]
        public void PriceOfResourceMax()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create temp price variable
            double TestPrice;
            //assign extreme min value
            TestPrice = 1.0;
            PriceOfResource = TestPrice.ToString().PadRight(53);
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*****************************PRICE OF RESOURCE MAX PLUS ONE   **********************************************************/

        [TestMethod]
        public void PriceOfResourceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create temp price variable
            double TestPrice;
            //assign extreme min value
            TestPrice = 100000.00;
            //add the temp var to test data
            PriceOfResource = TestPrice.ToString();
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /*****************************PRICE OF RESOURCE MID   **********************************************************/

        [TestMethod]
        public void PriceOfResourceMid()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create temp price variable
            double TestPrice;
            //assign extreme min value
            TestPrice = 1.0;
            PriceOfResource = TestPrice.ToString().PadRight(26);
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /*****************************PRICE OF RESOURCE EXTREME MAX   **********************************************************/

        [TestMethod]
        public void PriceOfResourceExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupply ASupply = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create temp price variable
            double TestPrice;
            //assign extreme min value
            TestPrice = 999999.99;
            //add the temp var to test data
            PriceOfResource = TestPrice.ToString();
            //invoke the method
            Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
