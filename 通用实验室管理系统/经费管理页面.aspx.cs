using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mysqlHelper;
using System.Data;
using System.Text;

public partial class 经费管理页面 : System.Web.UI.Page
{
    public void bind()
    {
        string sql = "select * from general_funds";
        DataTable dt = MysqlHelper.ExecuteDataTable(sql);
        GridView1.DataSource = dt;

        GridView1.DataBind();
 
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        string sql = "select * from general_funds";
        DataTable dt = MysqlHelper.ExecuteDataTable(sql);
        GridView1.DataSource = dt;

        //string my_sql = "select fText from general_funds";
        //IDataReader ds = MysqlHelper.ExecuteReader(my_sql);
        
        //读取text文本格式
        //string res = "1";
        //Response.Write(ds.Read());
        //while (ds.Read())
        //{
        //   res = ds.GetString(ds.GetOrdinal("fText"));
        //   Response.Write(res);
        //}
       
        if (!IsPostBack)
        {
            GridView1.DataBind();
        }
       //int i, j;
       //for (i = 0; i < dt.Rows.Count; i++)          //总行数
       //    for (j = 0; j < dt.Columns.Count; j++)        //总列数
       //        Response.Write(dt.Rows[i][j].ToString());

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string fId = GridView1.Rows[e.RowIndex].Cells[0].Text.ToString().Trim();
        string fFundBalance = GridView1.Rows[e.RowIndex].Cells[1].Text.ToString().Trim();
        string fDate = GridView1.Rows[e.RowIndex].Cells[2].Text.ToString().Trim();

        string my_sql = "delete from general_funds where fId='" + fId + "';";

        MysqlHelper.ExecuteNonQuery(my_sql);

        Response.Write("<script>alert(' 删除成功！')</script>");
        bind();
    }


    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        bind();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        bind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string fId  = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[0].Controls[0])).Text.ToString().Trim();
        string fFundBalance = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString().Trim();
        string fDate = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString().Trim();
        string fText = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString().Trim();
        string fFundChange = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text.ToString().Trim();

        string my_sql = "update general_funds set fFundBalance='" + fFundBalance + "',fDate='" + fDate + "', fText='" + fText + "',fFundChange='" + fFundChange + "' where fId="+fId;
        MysqlHelper.ExecuteNonQuery(my_sql);

        GridView1.EditIndex = -1;
        bind();
    }

}