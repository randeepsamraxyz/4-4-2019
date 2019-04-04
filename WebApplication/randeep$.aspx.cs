using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
   

        public partial class gagan : System.Web.UI.Page
        {
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!Page.IsPostBack)
                {
                    ltMessage.Text = "Welcome to the gagan page";
                    ltMessage.Text = "You are under my control now";
                }
            }

            protected void Button1_Click(object sender, EventArgs e)
            {
                string email = TextBox1.Text;
            }
        }
    }