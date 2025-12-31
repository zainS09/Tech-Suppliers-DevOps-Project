using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerId;
        //CustomerId public property
        public int CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }
        private bool mActive;
        //Active public property
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }
        private DateTime mDateOfBirth;
        //DateOfBirth public property
        public DateTime DateOfBirth
        {
            get
            {
                //this line of code sends data out of the property
                return mDateOfBirth;
            }
            set
            {
                //this line of code allows data into the property
                mDateOfBirth = value;
            }
        }
        private string mFullName;
        //FullName public property
        public string FullName
        {
            get
            {
                //this line of code sends data out of the property
                return mFullName;
            }
            set
            {
                //this line of code allows data into the property
                mFullName = value;
            }
        }
        private string mEmail;
        //Email public property
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }
        private string mPassword;
        //Password public property
        public string Password
        {
            get
            {
                //this line of code sends data out of the property
                return mPassword;
            }
            set
            {
                //this line of code allows data into the property
                mPassword = value;
            }
        }
        private string mAddress;
        //Address public property
        public string Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }

        public bool Find(int CustomerId)
        {
            //create an istance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@CustomerId", CustomerId);
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mActive = true;
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["Fullname"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string fullName, string password, string email, string address, string dateOfBirth)
        {
            String Error = "";
            DateTime DateTemp;

            //validate name
            if (fullName.Length <= 1)
            {
                Error = Error + "The FullName must not be less than 1 character : ";
            }

            if (fullName.Length > 50)
            {
                Error = Error + "The FullName must be less than 50 character : ";
            }

            //validate date
            try
            {
                //Copy the date of birth value to the DateTemp Variable
                DateTemp = Convert.ToDateTime(dateOfBirth);
                //mimium
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The Date cannot be above today's date ";
                }
                //mimum
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    Error = Error + "The date cannot be less than 100 years  ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date  ";
            }

            //if the Customer Address is blank or less
            if (address.Length <= 0)
            {
                //record the error
                Error = Error + "The Customer Address must not be blank  ";
            }

            //if the Customer Address is more than 50 character
            if (address.Length >= 50)
            {
                //record the error
                Error = Error + "The Customer Address must be less than 50 characters : ";
            }

            //if the customer Email is left blank
            if (email.Length < 11)
            {
                // Record the error
                Error = Error + "The Customer Email must not be less than 11 characters: ";
            }
            if (email.Length > 40)
            {
                // Record the error
                Error = Error + "The Customer Email must be less than 40 characters: ";
            }

            // Email format check
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address != email)
                {
                    Error = Error + "The Customer Email is not in a valid format: ";
                }
            }
            catch
            {
                Error = Error + "The Customer Email is not in a valid format: ";
            }

            if (password.Length< 10)
            {
                //record the error
                Error = Error + "The Customer Password may not be less 10 characters : ";
            }
            if (password.Length > 50)
            {
                //record the error
                Error = Error + "The Customer Password must be less than 40 characters : ";
            }

            return Error;
        } 
    }   
}


