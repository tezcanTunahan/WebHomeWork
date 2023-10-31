using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWorkOne
{
    public partial class _Default : Page
    {
        int Count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if(ViewState["Clicks"] != null)
            {
                Count = (int)ViewState["Clicks"] + 1;
            }
            TextBox1.Text = Count.ToString();
            ViewState["Clicks"] = Count;
        }
    }
}