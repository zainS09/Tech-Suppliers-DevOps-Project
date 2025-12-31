using System.Collections.Generic;
using System;

namespace ClassLibrary

{
    public class clsStaffCollection
    {
        
        // private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();

        // private member data for ThisStaff
        clsStaff mThisStaff = new clsStaff();

        // Public property to hold a list of staff
        public List<clsStaff> StaffList
        {
            get { return mStaffList; }
            set { mStaffList = value; }
        }


        // Public property to hold the count of staff items
        public int Count
        {
            get { return mStaffList.Count; }
            set { /* We can ignore setting the count, as it is managed by the list itself */ }
        }


        // Public property to hold a single staff object
        public clsStaff ThisStaff
        {
            get
            {
                // return the private data
                return mThisStaff;
            }
            set
            {
                // set the private data
                mThisStaff = value;
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
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff object
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                AStaff.Role = Convert.ToString(DB.DataTable.Rows[Index]["StaffRole"]);
                AStaff.DateHired = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateHired"]);
                AStaff.HourlyRate = Convert.ToDecimal(DB.DataTable.Rows[Index]["HourlyRate"]);
                AStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }
            public clsStaffCollection()
        {
           
            // object for data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the arry list with data table
            PopulateArray(DB);
           
        }

        public int Add()
        {
            // adds a record to the database based on the values of mThisStaff
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@StaffName", mThisStaff.Name);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffRole", mThisStaff.Role);
            DB.AddParameter("@DateHired", mThisStaff.DateHired);
            DB.AddParameter("@IsActive", mThisStaff.Active);
            DB.AddParameter("@HourlyRate", mThisStaff.HourlyRate);
            // execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            // update an existing record based on the values of ThisStaff
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@StaffID", ThisStaff.StaffId);
            DB.AddParameter("@StaffName", ThisStaff.Name);
            DB.AddParameter("@StaffEmail", ThisStaff.StaffEmail);
            DB.AddParameter("@StaffRole", ThisStaff.Role);
            DB.AddParameter("@DateHired", ThisStaff.DateHired);
            DB.AddParameter("@IsActive", ThisStaff.Active);
            DB.AddParameter("@HourlyRate", ThisStaff.HourlyRate);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            // deletes the record pointed to by thisStaff
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffId);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByRole(string Role)
        {
            //filters the records based on a full or partial role
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Role parameter to the database
            DB.AddParameter("@Role", Role);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByRole");
            PopulateArray(DB);
        }

     
        }

    }
