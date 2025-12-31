using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the stock id property
        private Int32 mStockId;
        //stock id public property
        public int StockId 
        {
            get
            {
                //sends data out of the property
                return mStockId;
            }
            set
            {
                //allows data into the property
                mStockId = value;
            } 
        }

        //private data member for the arrived on property
        private DateTime mArrivedOn;
        //arrived on public property
        public DateTime ArrivedOn 
        { 
            get
            {
                //sends data out of the property
                return mArrivedOn;
            }
            set
            {
                //allows data into the property
                mArrivedOn = value;
            }
        }

        //private data member for the item name property
        private String mItemName;
        //item name public property
        public string ItemName 
        {
            get
            {
                //sends data out of the property
                return mItemName;
            }
            set
            {
                //allows data into the property
                mItemName = value;
            }
        }

        //private data member for the quantity property
        private Int32 mQuantity;
        //quantity public property
        public int Quantity 
        {
            get
            {
                //sends data out of the property
                return mQuantity;
            }
            set
            {
                //allows data into the property
                mQuantity = value;
            }
        }

        //private data member for the price property
        private double mPrice;
        //price public property
        public double Price 
        {
            get
            {
                //sends data out of the property
                return mPrice;
            }
            set
            {
                //allows data into the property
                mPrice = value;
            }
        }

        //private data member for the available property
        private Boolean mAvailable;
        //available public property
        public Boolean Available 
        {
            get
            {
                //sends data out of the property
                return mAvailable;
            }
            set
            {
                //allows data into the property
                mAvailable = value;
            }
        }

        //private data member for the supplier id property
        private Int32 mSupplierId;
        //supplier id public property
        public int SupplierId 
        {
            get
            {
                //sends data out of the property
                return mSupplierId;
            }
            set
            {
                //allows data into the property
                mSupplierId = value;
            }
        }



        public bool Find(int stockId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the stock id to search for
            DB.AddParameter("@StockId", stockId);
            //execute stored procedure
            DB.Execute("sproc_tblStock_FilterByStockId");

            //if one record is found (Either one or zero)
            if (DB.Count == 1)
            {
                //copy data from the database to the private data members
                mStockId = Convert.ToInt32(DB.DataTable.Rows[0] ["StockId"]);
                mArrivedOn = Convert.ToDateTime(DB.DataTable.Rows[0]["ArrivedOn"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);

                //return that everything is OK
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string itemName, string arrivedOn, string quantity, string price, string supplierId)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store the date values
            DateTime DateTemp;

            //create temporary variable to store the int values
            int QuantityTemp;

            //create temporary variable to store double values
            double PriceTemp;

            //if the ItemName is blank
            if (itemName.Length == 0) //test the itemName param in method, not the public property ItemName
            {
                //record the error
                Error = Error + "The item name may not be blank : ";
            }

            //if the item name is greater than 70 chars
            if (itemName.Length > 70)
            {
                //record the error
                Error = Error + "The item name must be less than 70 characters : ";
            }

            //create an instance of DateTime (DateComp) to compare with DateTemp in the if statements
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy the arrivedOn value to the DateTemp variable
                DateTemp = Convert.ToDateTime(arrivedOn);

                if (DateTemp < DateComp)//compare the dates
                {
                    //record the error
                    Error = Error + "The date cannot be in the past :";
                }

                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future :";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            if (quantity == null || quantity == "")
            {
                Error = Error + "Quantity cannot be left blank : ";
            }
            else
            {
                try
                {
                    QuantityTemp = Convert.ToInt32(quantity);

                    if (QuantityTemp < 0)
                    {
                        Error = Error + "The quantity cannot be less than 0 : ";
                    }

                    if (QuantityTemp > 200)
                    {
                        Error = Error + "The quantity cannot be greater than 200 : ";
                    }


                }
                catch
                {
                    Error = Error + "The quantity was not valid : ";
                }
            }

            if (price == null || price == "")
            {
                Error = Error + "Price cannot be left blank : ";
            }
            else
            {
                try
                {
                    PriceTemp = Convert.ToDouble(price);

                    if (PriceTemp < 0.10)
                    {
                        Error = Error + "Price cannot be less than 0.1 : ";
                    }

                    if (PriceTemp > 10000.00)
                    {
                        Error = Error + "Price cannot be greater than 10,000";
                    }
                }
                catch
                {
                    Error = Error + "The price was not valid : ";
                }
            }


            //return any error messages
            return Error;
        }


    }
}