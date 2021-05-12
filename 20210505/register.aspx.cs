using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210505
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (user.Text != null && passwd.Text != null && Name.Text != null)
            {
                string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["AccountConnectionString"].ConnectionString;

                SqlConnection connection = new SqlConnection(s_data);
                connection.Open();
                //string SQLText = $"insert into [accountInformation](account,passwd,name) values('"+user.Text +"','"+passwd.Text+"','"+Name.Text+"')";
                string SQLText = $"insert into [accountInformation](account,passwd,name) values(@account, @passwd, @name )";
                SqlCommand Command = new SqlCommand(SQLText, connection);

                Command.Parameters.Add("@account", SqlDbType.NVarChar);
                Command.Parameters["@account"].Value = user.Text;

                Command.Parameters.Add("@passwd", SqlDbType.NVarChar);
                Command.Parameters["@passwd"].Value = passwd.Text;

                Command.Parameters.Add("@name", SqlDbType.NVarChar);
                Command.Parameters["@name"].Value = Name.Text;

                Command.ExecuteNonQuery();
                connection.Close();
                
                /*
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Command);//從Command取得資料存入dataAdapter
                                          
                DataSet dataset = new DataSet();//創一個dataset的記憶體資料集

                dataAdapter.Fill(dataset);//將dataAdapter資料存入dataset

               
                //新增一筆資料
                DataRow newRow = dataset.Tables["accountInformation"].NewRow();
                newRow["account"] = 999;
                newRow["passwd"] = 111;
                dataset.Tables["accountInformation"].Rows.Add(newRow);

                //移除一筆資料
                dataset.Tables["accountInformation"].Rows.Remove(dataset.Tables["accountInformation"].Rows[1]);

                //修改一筆資料
                DataRow[] rows = dataset.Tables["accountInformation"].Select("id=1");
                if (rows.Length > 0)
                {
                    rows[0]["id"] = 2;
                }
                */
            }


        }
    }
}