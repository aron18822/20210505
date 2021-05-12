using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210505
{
    public partial class ASHX_test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.PostedFile != null) 
            {
                HttpPostedFile myFile = FileUpload1.PostedFile;
                Session["myFile"] = myFile;
                Image1.ImageUrl = "Handler1.ashx";
            }

            /*string fileName;
            if (FileUpload1.HasFile)
            {
                if (FileUpload1.PostedFile.ContentType.IndexOf("image") == -1)
                {
                    Message.Text = "檔案型態錯誤!";
                    return;
                }
                string Extention = FileUpload1.FileName.Split('.')[FileUpload1.FileName.Split('.').Length - 1];
                fileName = String.Format("{0:yyyyMMddhhmmss}.{1}", DateTime.Now, Extention);
                FileUpload1.SaveAs(Server.MapPath(String.Format("~/images/{0}", fileName)));

            }
            else 
            {
                Message.Text = "沒有上傳檔案";
                return;
            }
            */
        }
    }
}