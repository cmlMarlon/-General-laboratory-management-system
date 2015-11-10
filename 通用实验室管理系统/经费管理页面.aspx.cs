using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using mysqlHelper;
using System.Data;
using System.Text;

public partial class 经费管理页面 : System.Web.UI.Page
{
    //修改日期
    private void ChangeDate(GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
            {
                //取出时间单元格
                string dt = e.Row.Cells[3].Text;
                if(dt != null && dt.Trim() != "")
                {
                    //将日期转换为长日期字符串格式
                    e.Row.Cells[3].Text = Convert.ToDateTime(dt).ToLongDateString();
                }

            }
        }
    }
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
        string fId = GridView1.DataKeys[e.RowIndex].Value.ToString().Trim();        //选取主键

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
        string fId = GridView1.DataKeys[e.RowIndex].Value.ToString().Trim();
        string fFundBalance = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString().Trim();
        string fDate = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString().Trim();
        string fText = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString().Trim();
        string fFundChange = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text.ToString().Trim();

        string my_sql = "update general_funds set fFundBalance='" + fFundBalance + "',fDate='" + fDate + "', fText='" + fText + "',fFundChange='" + fFundChange + "' where fId="+fId;
        MysqlHelper.ExecuteNonQuery(my_sql);

        GridView1.EditIndex = -1;
        bind();
    }

   
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./经费事件添加.aspx");
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bind();
    }
    protected void 事件查询_Click(object sender, EventArgs e)
    {
        if (事件查询框.Text != null)
        {
            string sql_news_f = "select * from general_TeamJournalism where tjTitle like '%" + 事件查询框.Text.Trim() + "%';";
            //Response.Write("<script>alert('" + 新闻查询框.Text.Trim() + "')</script>");
            DataTable ds = MysqlHelper.ExecuteDataTable(sql_news_f);
            GridView1.DataSource = ds;

            GridView1.DataBind();

        }
        else
        {
            Response.Write("<script>alert(' 请输入查询信息！')</script>");
        }
    }
}