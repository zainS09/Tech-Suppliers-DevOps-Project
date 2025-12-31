using System;

namespace ClassLibrary
{
    public class clsStockUser
    {

        //private data memebers
        private Int32 mUserID;
        private string mUserName;
        private string mPassword;
        private string mDepartment;


        public int UserID {
            get
            {
                return mUserID;
            }
            set
            {
                mUserID = value;
            }
        }

        public string UserName {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            } 
        }

        public string Password {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }

        public string Department {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;    
            }
        }

        public bool FindUser(string UserName, string Password)
        {
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //add parameters
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            //execute the sproc
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            //if one record is found (there shoudl be either one or none)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data memebers
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm it worked
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}