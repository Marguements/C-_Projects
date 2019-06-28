using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project6
{
    public partial class AccountView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void chkChangeGV_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChangeGV.Checked)
            {
                SqlDataSource1.SelectCommand = "SELECT * FROM [Accounts] where Balance < 0";
                AccountsGV.DataBind();
            }
            else
            {
                SqlDataSource1.SelectCommand = "SELECT * FROM [Accounts]";
                AccountsGV.DataBind();
            }
        }
    }
}