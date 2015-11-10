using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using mysqlHelper;
using System.Text;

public partial class 动态管理页面 : System.Web.UI.Page
{
    //新闻
    public void bind_news()
    {
        string sql_news = "select * from general_TeamJournalism";
        DataTable dt = MysqlHelper.ExecuteDataTable(sql_news);
        GridView1.DataSource = dt;
        if (!IsPostBack)
        {
            GridView1.DataBind();
        }
    }
    //动态
    public void bind_actives()
    {
        string sql_actives = "select * from general_TeamActive";
        DataTable dt = MysqlHelper.ExecuteDataTable(sql_actives);
        GridView2.DataSource = dt;
        if (!IsPostBack)
        {
            GridView2.DataBind();
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //动态加载
        string sql_actives = "select * from general_TeamActive";
        DataTable dt_2 = MysqlHelper.ExecuteDataTable(sql_actives);
        GridView2.DataSource = dt_2;
        //新闻加载
        string sql_news = "select * from general_TeamJournalism";
        DataTable dt = MysqlHelper.ExecuteDataTable(sql_news);
        GridView1.DataSource = dt;
        if (!IsPostBack)
        {
            GridView1.DataBind();
            GridView2.DataBind();
        }
    }


    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string tjId = GridView1.DataKeys[e.RowIndex].Value.ToString().Trim();        //选取主键

        string my_sql = "delete from general_TeamJournalism where tjId='" + tjId + "';";

        MysqlHelper.ExecuteNonQuery(my_sql);

        Response.Write("<script>alert(' 新闻删除成功！')</script>");
        bind_news();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        bind_news();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        bind_news();
    }
    protected void 新闻查询_Click(object sender, EventArgs e)
    {
        if (新闻查询框.Text != null)
        {
            string sql_news_f = "select * from general_TeamJournalism where tjTitle like '%" + 新闻查询框.Text.Trim() + "%';";
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