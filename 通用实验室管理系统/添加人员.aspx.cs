using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mysqlHelper;
using System.Data;
using System.Text;

public partial class 添加人员 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string pname = TextBox1.Text.ToString();
        string psex = TextBox2.Text.ToString();
        string pwd = TextBox3.Text.ToString();
        int phonenum = Convert.ToInt16(TextBox4.Text.ToString());
        string address = TextBox5.Text.ToString();
        int sLabid = Convert.ToInt16(TextBox6.Text.ToString());
        string workstate = TextBox7.Text.ToString();
        string laboratorypost = TextBox8.Text.ToString();
        int pay = Convert.ToInt16(TextBox9.Text.ToString());
        string laboratoryseat = TextBox10.Text.ToString();

        string sql = "insert into general_laboratory_member(pName, pSex, pPassword, pPoneNumber, pAddress, SlaveLaboratoryId, pWorkingsState, LaboratoryPost, Pay, LaboratorySeat) values('" + pname + "', '" + psex + "', '" + pwd + "', " + phonenum + ", '" + address + "', " + sLabid + ", '" + workstate + "', '" + laboratorypost + "', " + pay + ", '" + laboratoryseat + "')";
        if (MysqlHelper.ExecuteNonQuery(sql) != null)
        {
            Response.Write("<script>alert('添加成功！');window.location.href='人员管理.aspx';</script>");
        }
        else
        {
            Response.Write("<script>alert('添加失败！');</script>");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("人员管理.aspx");
    }
}