using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210505
{
    public partial class room : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logined"] == null)
            {
                //Response.Redirect("login1");
                Server.Transfer("login1.aspx");
            }
            /*if (!IsPostBack)
            {
                if (Session["nickname"] != null)
                {
                    Application.Add(Session["nickname"].ToString(), Session["nickname"]);
                }
                lblChat.Text = Application["content"].ToString();
            }*/
            Label2.Text = "線上人數:" + Convert.ToString(Application["count"]);
            
        }
        protected void logout_Click(object sender, EventArgs e)
        {
            Application["count"] = Convert.ToInt32(Application["count"]) - 1;
            Session.RemoveAll();
            Response.Redirect("login1");
        }

        protected void btnMessage_Click(object sender, EventArgs e)
        {
            string message = TextBox1.Text;
            Application["messageResult"] = Application["messageResult"] +
                Session["nickname"].ToString() +
                ":" +
                message +
                "<br>";
        }
        

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (Application["messageResult"] != null)
                lblChat.Text = Application["messageResult"].ToString();
        }
    }
}