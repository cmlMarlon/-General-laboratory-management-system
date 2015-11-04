using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using mysqlHelper;

public partial class 经费事件添加 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string fId = TextBox1.Text.Trim();
        string fFundBalance = TextBox2.Text.Trim();
        string fDate = TextBox3.Text.Trim();
        string fText = TextBox4.Text.Trim();
        string fFundChange = TextBox5.Text.Trim();

        string fTeam = "小组";    //传参数

        if ((fId.Length == 0) || (fFundBalance.Length == 0) || (fDate.Length == 0) || (fText.Length == 0) || (fFundChange.Length == 0))
        {
            Response.Write("<script>alert('所有信息都为必填项，请检查是否漏填！')</script>");
        }
        string str = "insert into  general_funds values('" + fId + "','" + fFundBalance + "','" + fDate + "','" + fText + "','" + fFundChange + "','"+ fTeam +"')";
        MysqlHelper.ExecuteNonQuery(str);

        Response.Redirect("./经费管理页面.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("./经费管理页面.aspx");
    }
}