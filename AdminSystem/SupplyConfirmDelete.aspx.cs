using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 SupplyID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the supply to be deleted from the session object 
        SupplyID = Convert.ToInt32(Session["SupplyID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the supply collection class
        clsSupplyCollection Supply = new clsSupplyCollection();
        //find the record to delete
        Supply.ThisSupply.Find(SupplyID);
        //delete the record
        Supply.Delete();
        //redirect back to main page
        Response.Redirect("SupplyList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("SupplyList.aspx");
    }
}