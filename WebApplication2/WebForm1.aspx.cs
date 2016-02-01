using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
      
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.Second.ToString();
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = DateTime.Now.Millisecond.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label3.Text = DateTime.Now.ToString();
        }
    }
}