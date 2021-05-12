using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState; // 因有用到Session 故引用


namespace _20210505
{
    /// <summary>
    /// Handler1 的摘要描述
    /// </summary>
    public class Handler1 : IHttpHandler, IRequiresSessionState// 因有用到Session 故引用
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Session["myFile"] != null) 
            {
                HttpPostedFile myFile = (HttpPostedFile)context.Session["myFile"];
                int myFile_Length = myFile.ContentLength;
                //設定緩衝區大小
                byte[] myData = new byte[myFile_Length];
                //myFile檔案的內容讀取到位元組陣列
                myFile.InputStream.Read(myData, 0, myFile_Length);
                //告訴瀏覽器檔案為image/jpeg的MIME類型
                context.Response.ContentType = "image/jpeg";
                //將二進位字元的字串寫入HTTP輸出資料流
                context.Response.BinaryWrite(myData);
            }
        }
        

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}