using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        ACustomer.ThisCustomer.Find(CustomerId);
        ACustomer.Delete();
        Response.Redirect("ListOfCustomers.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
                Response.Redirect("ListOfCustomers.aspx");

    }
}
