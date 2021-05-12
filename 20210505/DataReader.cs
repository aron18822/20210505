//創一個變數存放從config內的資訊，其實也可不用創立這變數，直接放進SqlConnection內即可。
string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["config中connectionString的name"].ConnectionString;  

//new一個SqlConnection物件，是與資料庫連結的通道(其名為Connection)，以s_data內的連接字串連接所對應的資料庫。
SqlConnection connection = new SqlConnection(s_data); 

//new一個SqlCommand告訴這個物件準備要執行什麼SQL指令
SqlCommand Command =new SqlCommand($"SQL語法指令", connection);

//與資料庫連接的通道開啟
connection.Open();

//new一個DataReader接取Execute所回傳的資料。
SqlDataReader Reader = Command.ExecuteReader();

//檢查是否有資料列
if (Reader.HasRows){
	//使用Read方法把資料讀進Reader，讓Reader一筆一筆順向指向資料列，並回傳是否成功。
	if (Reader.Read()) {
	   //DataReader讀出欄位內資料的方式，通常也可寫Reader[0]、[1]...[N]代表第一個欄位到N個欄位。
	   TextBox.Text = Reader["欄位名稱"].ToString();	   
	}
}   

//關閉與資料庫連接的通道
connection.Close(); 