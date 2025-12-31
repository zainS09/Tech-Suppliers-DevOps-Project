using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerId = 1;
            TestItem.FullName = "Jainik Ratilal";
            TestItem.Address = "DMU Road";
            TestItem.Email = "Jainikratilal@gmail.com";
            TestItem.DateOfBirth = Convert.ToDateTime("17/03/2004");
            TestItem.Password = "Password123";
            TestItem.Active = true;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();

            TestCustomer.CustomerId = 1;
            TestCustomer.FullName = "Jainik Ratilal";
            TestCustomer.Address = "DMU Road";
            TestCustomer.Email = "Jainikratilal@gmail.com";
            TestCustomer.DateOfBirth = Convert.ToDateTime("17/03/2004");
            TestCustomer.Password = "Password123";
            TestCustomer.Active = true;
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

            TestItem.CustomerId = 1;
            TestItem.FullName = "Jainik Ratilal";
            TestItem.Address = "DMU Road";
            TestItem.DateOfBirth = Convert.ToDateTime("17/03/2004");
            TestItem.Email = "Jainikratilal@gmail.com";
            TestItem.Password = "Password123";
            TestItem.Active = true;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerId = 1;
            TestItem.FullName = "Jainik Ratilal";
            TestItem.Address = "DMU Road";
            TestItem.DateOfBirth = Convert.ToDateTime("17/03/2004");
            TestItem.Email = "Jainikratilal@gmail.com";
            TestItem.Password = "Password123";
            TestItem.Active = true;
            AllCustomers.ThisCustomer = TestItem;
            TestItem.CustomerId = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerId = 1;
            TestItem.FullName = "Jainik Ratilal";
            TestItem.Address = "DMU Road";
            TestItem.DateOfBirth = Convert.ToDateTime("17/03/2004");
            TestItem.Email = "Jainikratilal@gmail.com";
            TestItem.Password = "Password123";
            TestItem.Active = true;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerId = PrimaryKey;
            TestItem.FullName = "Jainikkumar Ratilal";
            TestItem.Address = "DMU University Road";
            TestItem.DateOfBirth = Convert.ToDateTime("17/03/2004");
            TestItem.Email = "Jainikratilal@gmail.com";
            TestItem.Password = "Password123";
            TestItem.Active = false;
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerId = 1;
            TestItem.FullName = "Jainik Ratilal";
            TestItem.Address = "DMU Road";
            TestItem.DateOfBirth = Convert.ToDateTime("17/03/2004");
            TestItem.Email = "Jainikratilal@gmail.com";
            TestItem.Password = "Password123";
            TestItem.Active = true;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerId = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found );
        }
        [TestMethod]
        public void ReportByFullNameMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByFullName("XXXXX XXXX");
            Assert.AreEqual(0, FilteredCustomers.Count );  
        }
        [TestMethod]
        public void ReportByFullNameDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomers.ReportByFullName("Jainik Ratilal");
            if (FilteredCustomers.Count == 2)
            {
                if (FilteredCustomers.CustomerList[0].CustomerId != 1)
                {
                    OK = false;
                }
                if (FilteredCustomers.CustomerList[0].CustomerId != 54)
                {
                    OK = false;
                }
                else
                {
                    OK = false;
                }
                Assert.IsTrue( OK );
            }
        }
    }
}
