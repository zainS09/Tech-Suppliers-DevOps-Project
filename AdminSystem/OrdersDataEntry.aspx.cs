using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderId"]);
        if (!IsPostBack)
        {
            // if this is not a new record
            if (OrderID != -1)
            {
                // display the current data for the record
                DisplayOrders();
            }
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Customer class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderID = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrder.Find(OrderID);
        //if found
        if (Found == true)
        {
            //display the value of the properties in the form
            lblError.Text = "";
           
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtShippingAddress.Text = AnOrder.ShippingAdress;
            txtPaymentMethod.Text = AnOrder.PaymentMethod;
            chkArrival.Checked = AnOrder.Order_Arrival;
        }
        else
        {
            
            txtOrderDate.Text = "";
            txtShippingAddress.Text = "";
            txtPaymentMethod.Text = "";
            lblError.Text = "Error: This Id doesn't exist!";
            lblError.Visible = true;
        }

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        
        clsOrder Anorder = new clsOrder();
        
        int OrderID = Convert.ToInt32(Session["OrderId"]);
        string OrderDate = txtOrderDate.Text;
        string Adress = txtShippingAddress.Text;      
        bool Arrival = chkArrival.Checked;
        string method = txtPaymentMethod.Text;
        string Error = "";
        Error = Anorder.Valid(Adress, method, OrderDate);
        if (Error == "")
        {
            Anorder.OrderId = OrderID;
            //capture the payment method
            Anorder.PaymentMethod = method;
            //capture the order date
            Anorder.OrderDate = Convert.ToDateTime(OrderDate);           
            //Capture the address
            Anorder.ShippingAdress = Adress;
            
            Anorder.Order_Arrival = Arrival;
            clsOrderCollection OrderList = new clsOrderCollection();
            if (OrderID == -1)
            {
                OrderList.ThisOrder = Anorder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = Anorder;
                OrderList.Update();
            }
            Response.Redirect("OrdersList.aspx");
        }


        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }
    void DisplayOrders()
    {
        // create an instance of the staff collection
        clsOrderCollection OrderCollection = new clsOrderCollection();
        // find the record to update
        OrderCollection.ThisOrder.Find(OrderID);
        // display the data for this record
        txtOrderID.Text = OrderCollection.ThisOrder.OrderId.ToString();
        txtShippingAddress.Text = OrderCollection.ThisOrder.ShippingAdress;
        txtPaymentMethod.Text = OrderCollection.ThisOrder.PaymentMethod;
        txtOrderDate.Text = OrderCollection.ThisOrder.OrderDate.ToString();
        chkArrival.Checked = OrderCollection.ThisOrder.Order_Arrival;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}