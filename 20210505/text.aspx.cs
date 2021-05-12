using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210505
{
    public partial class text : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["logined"] != null && Session["logined"].ToString() == "1")
            {
                Response.Redirect("text2");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            /*if (user.Text == "lccnet")
            {
                if (passwd.Text == "123456")
                {
                    Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                    Session["logined"] = "1";
                    Response.Redirect("text2");
                }
                else
                {
                    passwdLabel.Text = "密碼輸入錯誤";
                }
            }
            else
            {
                userLabel.Text = "帳號輸入錯誤";
            }*/
            
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["AccountConnectionString"].ConnectionString;

            SqlConnection connection = new SqlConnection(s_data);
            string sqlTest = "select * from accountInformation where account ='"+ user.Text+"'";
            SqlCommand Command = new SqlCommand(sqlTest, connection);

            connection.Open();

            SqlDataReader Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                if (Reader.Read())
                {
                    if (Reader["passwd"].ToString() == passwd.Text)
                    {
                        Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                        Session["logined"] = "1";
                        Response.Redirect("text2");
                    }
                    else
                    {
                        Label1.Text = "密碼錯誤!!";
                    }
                }
            }
            else 
            {
                Label1.Text = "無此帳號!!";
            }

            connection.Close();
        }
        
    }
}