using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210505
{
    public partial class login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Application["content"] = "聊天記錄\n";
            if (!IsPostBack)
            {
                user.Text = "請輸入帳號";
                passwd.Text = "請輸入密碼";
                Name.Text = "請輸入暱稱";
            }
            if (Session["logined"] != null && Session["logined"].ToString() == "1")
            {
                //Response.Redirect("room");
                Server.Transfer("room.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (user.Text == "lccnet")
            {
                if (passwd.Text == "123456")
                {
                    Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                    Session["logined"] = "1";
                    Session["nickname"] = Name.Text;
                    //Response.Redirect("room");
                    Server.Transfer("room.aspx");
                }
                else
                {
                    passwdLabel.Text = "密碼輸入錯誤";
                }
            }
            else
            {
                userLabel.Text = "帳號輸入錯誤";
            }
        }

    }
}