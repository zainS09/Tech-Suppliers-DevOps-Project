using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return OrderList.Count;
            }
            set
            {

            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff object
                clsOrder Anorder = new clsOrder();
                //read in the fields from the current record
                Anorder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                Anorder.PaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["Payment_Method"]);
                Anorder.ShippingAdress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAdress"]);
                Anorder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                Anorder.Order_Arrival = Convert.ToBoolean(DB.DataTable.Rows[Index]["Order_Arrival"]);
                //add the record to the private data member
                mOrderList.Add(Anorder);
                //point at the next record
                Index++;
            }
        }



        public clsOrderCollection()
        {
            // object for data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblOrders_SelectAll");
            //populate the arry list with data table
            PopulateArray(DB);
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Payment_Method", mThisOrder.PaymentMethod);
            DB.AddParameter("@ShippingAdress", mThisOrder.ShippingAdress);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Order_Arrival", mThisOrder.Order_Arrival);
            return DB.Execute("sproc_tblOrders_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderId);
            DB.AddParameter("@ShippingAdress", mThisOrder.ShippingAdress);
            DB.AddParameter("@Payment_Method", mThisOrder.PaymentMethod);
            
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            
            DB.AddParameter("@Order_Arrival", mThisOrder.Order_Arrival);
            DB.Execute("sproc_tblOrders_Update");
        }

        public void Delete()
        {
            // deletes the record pointed to by thisStaff
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderId);
            // execute the stored procedure
            DB.Execute("sproc_tblOrders_Delete");
        }
        public void ReportByAdress(string adress)
        {
            //filters the records based on a full or partial role
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Role parameter to the database
            DB.AddParameter("@ShippingAdress", adress);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByAdress");
            PopulateArray(DB);
        }

    }
}
