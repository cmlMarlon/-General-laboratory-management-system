using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using mysqlHelper;

public partial class 活动添加 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string path = FileUpload1.PostedFile.FileName;

        string fileImageNo = Path.GetFileName(FileUpload1.PostedFile.FileName);

        if (fileImageNo.Trim().Length != 0)
        {
            System.IO.File.Copy(path, Server.MapPath("./Images/" + fileImageNo), true);
        }
        //活动信息收集
        string taId = TextBox1.Text.Trim();
        string taDate = TextBox2.Text.Trim();
        string taTitle = TextBox3.Text.Trim();
        string taText = TextBox4.Text.Trim();
        string taImage = "./Images/" + fileImageNo;


        if ((taId.Length == 0) || (taDate.Length == 0) || (taTitle.Length == 0) || (taText.Length == 0) || (taImage.Length == 0))
        {
            Response.Write("<script>alert('为必填项信息，请检查是否漏填！')</script>");
        }
        string str = "insert into general_TeamActive values('" + taId + "','" + taDate + "','" + taTitle + "','" + taText + "','" + taImage + "');";
        MysqlHelper.ExecuteNonQuery(str);

        Response.Redirect("./动态管理页面.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("./动态管理页面.aspx");
    }
}