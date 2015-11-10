using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mysqlHelper;
using System.IO;
using System.Data;

public partial class 新闻详情 : System.Web.UI.Page
{
     private string tjId_find;
     private static string image_yuan;
     protected void Page_Load(object sender, EventArgs e)
     {
         //获得新闻数据库长度
         string sqlcount = "select count(*) from general_TeamJournalism";
         DataTable dt_count = MysqlHelper.ExecuteDataTable(sqlcount);
         int llength = Convert.ToInt32(dt_count.Rows[0][0]);

         string[] tjId_table = new string[llength];           //编号
         string[] tjDate_table = new string[llength];         //时间
         string[] tjTitle_table = new string[llength];        //标题
         string[] tjText_table = new string[llength];         //内容
         string[] tjImage_table = new string[llength];        //图片

         string sql = "select * from general_TeamJournalism";
         DataTable dt = MysqlHelper.ExecuteDataTable(sql);
         int i;
         for (i = 0; i < tjId_table.Length; i++)
         {
             tjId_table[i] = dt.Rows[i][0].ToString().Trim();
             tjDate_table[i] = dt.Rows[i][1].ToString().Trim();
             tjTitle_table[i] = dt.Rows[i][2].ToString().Trim();
             tjText_table[i] = dt.Rows[i][3].ToString().Trim();
             tjImage_table[i] = dt.Rows[i][4].ToString().Trim();
         }

         int j = 0;
         if (!IsPostBack)
         {
             if (Request.QueryString["id"] != null)
             {
                 tjId_find = Request.QueryString["id"];
                 for (j = 0; j < tjId_table.Length; j++)
                 {
                     if (tjId_table[j].ToString().Trim() == tjId_find)
                     {

                         tjDate.Text = tjDate_table[j];
                         tjTitle.Text = tjTitle_table[j];
                         tjText.Text = tjText_table[j];
                         tjImage.ImageUrl = tjImage_table[j];

                         //------------------------textbox--------------------------//
                         tjdateBox.Text = tjDate_table[j];
                         tjtitleBox.Text = tjTitle_table[j];
                         tjtextBox.Text = tjText_table[j];
                         image_yuan = tjImage_table[j];
                         break;
                     }
                 }
             }
         }
     }
     protected void 提交修改_Click(object sender, EventArgs e)
     {
         if (Request.QueryString["id"] != null)
         {
             tjId_find = Request.QueryString["id"];
         }
         //Response.Write("<script>alert('"+ tjId_find + "')</script>");
         string tjImage_change;
         string pa = FileUpload1.PostedFile.FileName;
         string path = Path.GetFileName(FileUpload1.PostedFile.FileName);

         if (pa.Trim().Length != 0)
         {
             System.IO.File.Copy(pa, Server.MapPath("./Images/" + path), true);

             tjImage_change = "./Images/" + path;
         }
         else
         {
             tjImage_change = image_yuan;
         }
         string my_sql = "update general_TeamJournalism set tjDate='" + tjdateBox.Text.Trim() + "',tjTitle='" + tjtitleBox.Text.Trim() + "', tjText='"+tjtextBox.Text.Trim()+"',tjImage='" + tjImage_change + "' where tjId=" + tjId_find;
         MysqlHelper.ExecuteNonQuery(my_sql);

         Response.Redirect("./新闻详情.aspx?id=" + tjId_find);
     }
}