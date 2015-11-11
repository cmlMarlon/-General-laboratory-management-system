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


public partial class 人员管理 : System.Web.UI.Page
{

    protected void bind()
    {
        string sql = "select * from general_laboratory_member";
        DataTable ds = MysqlHelper.ExecuteDataTable(sql);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        string sql = "select * from general_laboratory_member";
        DataTable ds = MysqlHelper.ExecuteDataTable(sql);
        GridView1.DataSource = ds;
        if (!IsPostBack)
        {
            GridView1.DataBind();
        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        bind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
        string del="delete from general_laboratory_member where pId='"+id+"'";
        MysqlHelper.ExecuteNonQuery(del);
        bind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
        string pname = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString().Trim();
        string sex = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString().Trim();
        string paddress = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString().Trim();
        string laboratorypost = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text.ToString().Trim();
        string pworkingsstate = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[5].Controls[0])).Text.ToString().Trim();
        string pay = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[6].Controls[0])).Text.ToString().Trim();
        string update = "update general_laboratory_member set pName='" + pname + "', pSex='"+sex+"', pAddress='"+paddress+"', LaboratoryPost='"+laboratorypost+"', pWorkingsState='"+pworkingsstate+"', Pay='"+pay+"'  where pId="+id+"";
        MysqlHelper.ExecuteNonQuery(update);
        GridView1.EditIndex = -1;
        bind();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        bind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("添加人员.aspx");
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bind();
    }

    protected void search(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        GridViewRow row = (GridViewRow)btn.Parent.Parent;
        string id = row.Cells[0].Text.ToString();
        string sql = "select pjName from general_project a, general_member_project b where pId = " + id + " and a.pjId = b.pjId";
        DataTable dt = MysqlHelper.ExecuteDataTable(sql);
        string pjName = dt.Rows[0][0].ToString();
        Response.Write("<script>alert('项目名称："+pjName+"');</script>");
    }
}