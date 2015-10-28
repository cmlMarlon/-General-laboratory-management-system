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
        string sql = "select id, name from test";
        DataTable dt = MysqlHelper.ExecuteDataTable(sql);
        GridView1.DataSource = dt;

        GridView1.DataBind();
 
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        string sql = "select * from test";
        DataTable dt = MysqlHelper.ExecuteDataTable(sql);
        GridView1.DataSource = dt;
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
        string Testid = GridView1.Rows[e.RowIndex].Cells[0].Text.ToString().Trim();
        string my_sql = "delete from test where id=" + Testid;

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
        string id = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[0].Controls[0])).Text.ToString().Trim();
        string name = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString().Trim();
        //byte[] bytes = Encoding.UTF8.GetBytes(name);
        //string aaa2 = System.Text.Encoding.UTF8.GetString(bytes);
        string my_sql = "update test set id=" + id + ", name='" + name + "' where id=" + id;
        MysqlHelper.ExecuteNonQuery(my_sql);

        GridView1.EditIndex = -1;
        bind();
    }

}