using System;
using System.Diagnostics;

namespace ClassLibrary
{
    public class clsSupply
    {
        //private data member for the Supply ID property
        private Int32 mSupplyID;

        //SupplyID public property
        public Int32 SupplyID
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplyID;
            }
            set
            {
                //this line of code allows data into the property
                mSupplyID = value;
            }
        }

        //private data member for the Availability Of Supplier
        private Boolean mAvailabilityOfSupplier;
        //Availability Of Supplier public property
        public bool AvailabilityOfSupplier
        {
            get
            {
                //this line of code sends data out of the property
                return mAvailabilityOfSupplier;
            }
            set
            {
                //this line of code allows data into the property
                mAvailabilityOfSupplier = value;
            }
        }


        //private data member for the Date Requested property
        private DateTime mDateRequested;
        //Date Requested public property
        public DateTime DateRequested
        {
            get
            {
                //this line of code sends data out of the property
                return mDateRequested;
            }
            set
            {
                //this line of code allows data into the property
                mDateRequested = value;
            }
        }




        //private data member for the To Be Delivered By property
        private DateTime mToBeDeliveredBy;
        //To Be Delivered By public property
        public DateTime ToBeDeliveredBy
        {
            get
            {
                //this line of code sends data out of the property
                return mToBeDeliveredBy;
            }
            set
            {
                //this line of code allows data into the property
                mToBeDeliveredBy = value;
            }
        }


        //private data member for the Supplier Contact property
        private string mSupplierContact;
        //Supplier Contact public property
        public string SupplierContact
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplierContact;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierContact = value;
            }
        }

        //private data member for the Price Of Resource property
        public double mPriceOfResource;
        //Price Of Resource public property
        public double PriceOfResource
        {
            get
            {
                //this line of code sends data out of the property
                return mPriceOfResource;
            }
            set
            {
                //this line of code allows data into the property
                mPriceOfResource = value;
            }
        }

        /**********************FIND METHOD*******************/

        public bool Find(int SupplyID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Supply ID to search for
            DB.AddParameter("@SupplyID", SupplyID);
            //execute the stored procedure
            DB.Execute("sproc_tblSupply_FilterBySupplyID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mSupplyID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplyID"]);
                mSupplierContact = Convert.ToString(DB.DataTable.Rows[0]["SupplierContact"]);
                mPriceOfResource = Convert.ToDouble(DB.DataTable.Rows[0]["PriceOfResource"]);
                mDateRequested = Convert.ToDateTime(DB.DataTable.Rows[0]["DateRequested"]);
                mAvailabilityOfSupplier = Convert.ToBoolean(DB.DataTable.Rows[0]["AvailabilityOfSupplier"]);
                mToBeDeliveredBy = Convert.ToDateTime(DB.DataTable.Rows[0]["ToBeDeliveredBy"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }

        /***************************VALID METHOD*********************/
        public string Valid(string supplierContact, string priceOfResource, string dateRequested, string toBeDeliveredBy)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store the date values 
            DateTime DateTemp;

            //create a temporary variable to store the double values
            double PriceTemp;

            //if the SupplierContact is blank
            if (supplierContact.Length == 0)
            {
                //record the error
                Error = Error + "The supplier contact may not be blank : ";
            }
            //if the supplier contact is greater than 50 characters
            if (supplierContact.Length > 50)
            {
                //record the error
                Error = Error + "The supplier contact must be less than 50 characters : ";
            }
            //create an instance of DateTime to compare woth DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the dateRequested value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateRequested);

                if (DateTemp < DateComp) //compare dateRequested with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error 
                Error = Error + "The date was not a valid date : ";
            }
            

            //priceOfResource parameter
            if (priceOfResource == null || priceOfResource == "")
            {
                Error = Error + "Please enter a value for price : ";
            }

            else

            {
                try
                {
                    PriceTemp = Convert.ToDouble(priceOfResource);

                    if (PriceTemp < 1)
                    {
                        Error = Error + "Price cannot be less than 1 : ";
                    }

                    if (PriceTemp > 99999.99)
                    {
                        Error = Error + "Price cannot be greater than 99999.99";
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