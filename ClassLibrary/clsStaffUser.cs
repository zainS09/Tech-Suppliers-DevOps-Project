using System;

namespace ClassLibrary
{
    public class clsStaffUser
    {
        // Private data member for the user id property
        private Int32 mUserID;
        // Private data member for the user name property
        private string mUserName;
        // Private data member for the password property
        private string mPassword;
        // Private data member for the department property
        private string mDepartment;

        // Private data member for the department property
        // Public property for UserID
        public int UserID
        {
            get { return mUserID; }
            set { mUserID = value; }
        }

        // Public property for UserName
        public string UserName
        {
            get { return mUserName; }
            set { mUserName = value; }
        }

        // Public property for Password
        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        // Public property for Department
        public string Department
        {
            get { return mDepartment; }
            set { mDepartment = value; }
        }
        
        public bool FindUser(string UserName, string Password)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the user username and password to search for
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            //execute the stored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            //if one record is found (there should be either one or none)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm everything worked ok
                return true;
            }
            else
            {
                //return false indicating a problem
                return false;
            }
        }

    }
}