using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mysqlHelper;
using System.Data;

public partial class 新闻详情 : System.Web.UI.Page
{
     private string tjId_find;
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
             //------------------------textbox--------------------------//
             tjdateBox.Text = dt.Rows[i][1].ToString().Trim();
             tjtitleBox.Text = dt.Rows[i][2].ToString().Trim();
             tjtextBox.Text = dt.Rows[i][3].ToString().Trim();
         }

         int j = 0;
         if (Request.QueryString["id"] != null)
         {
             tjId_find = Request.QueryString["id"];
             for (j = 0; j < tjId_table.Length; j ++)
             {
                 if (tjId_table[j].ToString().Trim() == tjId_find)
                 {
                     tjDate.Text = tjDate_table[j];
                     tjTitle.Text = tjTitle_table[j];
                     tjText.Text = tjText_table[j];
                     tjImage.ImageUrl = tjImage_table[j];
                     break;
                 }
             }
         }
     }
}