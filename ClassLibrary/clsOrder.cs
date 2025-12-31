using System;
using System.Net;

namespace ClassLibrary
{
    public class clsOrder
    {
        private bool mOrderArrival;
        public bool Order_Arrival {
            get { return mOrderArrival; }
            set { mOrderArrival = value; }
        
        }
        private Int32 mStockID; 
        public int StockID { 
            get { return mStockID; }
            set { mStockID = value; }
      
        }
        private Int32 mStaffID;
        public int StaffID { 
            get { return mStaffID; }
            set { mStaffID = value; }       
        }
        private Int32 mCustomerID;
        public int CustomerID { 
            get { return mCustomerID; }
            set { mCustomerID = value; }    
        
        }
        private string mShippingAdress;
        public string ShippingAdress {
            get { return mShippingAdress; }
            set { mShippingAdress = value; }
        
        }
        private string mPaymentMethod;
        public string PaymentMethod { 
            get { return mPaymentMethod; }
            set { mPaymentMethod = value; }
        }
        private Int32 mOrderId; 
        public int OrderId { 
            get { return mOrderId; }
            set { mOrderId = value; }
        }
        private DateTime mOrderDate;
        public DateTime OrderDate { 
            get { return mOrderDate; }  
            set { mOrderDate = value; }
        
        }
        public bool Find(int OrderID)
        {
            //create an istance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrders_FilterByOrderID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mOrderArrival = true;
                mShippingAdress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAdress"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["Payment_Method"]);
                
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
        public string Valid(string adress, string method,string OrderDate)
        {
            String Error = "";
            DateTime DateTemp;

            //validate name
            if (adress.Length <= 0)
            {
                Error = Error + "The adress must not be blank : ";
            }

            if (adress.Length > 200)
            {
                Error = Error + "The adress must not be so long : ";
            }
            if (method.Length <= 0)
            {
                Error = Error + "The Payment method must not be blank";

            }
            if(method != "visa" && method !="master card" && method !="paypal"   )
            {

                Error = Error + "The Payment method should either be visa, master card or paypal";

            }
            

            //validate date
            try
            {
               
                DateTemp = Convert.ToDateTime(OrderDate);
                
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The Date cannot be above today's date : ";
                }
                //mimum
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    Error = Error + "The date cannot be less than 100 years : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            return Error;
        }






















    }
}