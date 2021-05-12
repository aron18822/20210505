using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210505
{
    public partial class text2 : System.Web.UI.Page
        
    {
        static int ct = 30;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logined"] == null) 
            {
                Response.Redirect("text");
            }
            Label2.Text = "線上人數:" + Convert.ToString(Application["count"]);
        }

        protected void Button_Click(object sender, ImageClickEventArgs e)
        {
            int user = 0;
            if (sender == ImageButton1)
            {
                user = 1;
                userResult.Text = "玩家出剪刀";
            }
            else if (sender == ImageButton2)
            {
                user = 2;
                userResult.Text = "玩家出石頭";
            }
            else if (sender == ImageButton3)
            {
                user = 3;
                userResult.Text = "玩家出布";
            }

            Random rnd = new Random();
            int computer = rnd.Next(1, 4);
            if (computer == 1)
            {
                computerResult.Text = "電腦出剪刀";
                computerImage.ImageUrl = "~/pic/scissors.png";
            }
            else if (computer == 2)
            {
                computerResult.Text = "電腦出石頭";
                computerImage.ImageUrl = "~/pic/stone.png";
            }
            else if (computer == 3)
            {
                computerResult.Text = "電腦出布";
                computerImage.ImageUrl = "~/pic/paper.png";
            }


            if ((user == 1 && computer == 3) ||
                (user == 2 && computer == 1) ||
                (user == 3 && computer == 2))
            {
                final.Text = "玩家贏了";
                Session["win"] = Convert.ToInt32(Session["win"]) + 1;
                LabelWin.Text = "贏" + Convert.ToString(Session["win"]) + "次";
            }
            else if ((user == 1 && computer == 2)
                || (user == 2 && computer == 3)
                || (user == 3 && computer == 1))
            {
                final.Text = "玩家輸了";
                Session["lose"] = Convert.ToInt32(Session["lose"]) + 1;
                LabelLose.Text = "輸" + Convert.ToString(Session["lose"]) + "次";
            }
            else
            {
                final.Text = "平手";
                Session["even"] = Convert.ToInt32(Session["even"]) + 1;
                Labeleven.Text = "平手" + Convert.ToString(Session["even"]) + "次";
            }
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Application["count"] = Convert.ToInt32(Application["count"]) - 1;
            Session.RemoveAll();
            Response.Redirect("text");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            ct--;
            Label3.Text = "倒數時間:" + ct.ToString();
        }
    }
}