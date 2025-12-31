using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StaffID;

  protected void Page_Load(object sender, EventArgs e)
    {
    // get the number of the staff member to be deleted from the session object
     StaffID = Convert.ToInt32(Session["StaffId"]);
     }



    protected void btnNo_Click(object sender, EventArgs e)
    {
        // redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        
            // create a new instance of the staff collection class
            clsStaffCollection StaffList = new clsStaffCollection();
            // find the record to delete
            StaffList.ThisStaff.Find(StaffID);
            //delete the record
            StaffList.Delete();
            // redirect back to the main page
            Response.Redirect("StaffList.aspx");
        

    }
}
