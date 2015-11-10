using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mysqlHelper;
using System.IO;

public partial class 新闻添加 : System.Web.UI.Page
{
    protected void Button1_Click(object sender, EventArgs e)
    {
        string path = FileUpload1.PostedFile.FileName;
        //Response.Write("<script>alert('" + path + "')</script>");
        string fileImageNo = Path.GetFileName(FileUpload1.PostedFile.FileName);

        if (fileImageNo != null)
        {
           System.IO.File.Copy(path, Server.MapPath("./Images/" + fileImageNo), true);
        }
        //-----------------------------------------------------------------------------/
        //这是一个上传图片的例子，上传其他文件都一样 
        //string strFileFullName = System.IO.Path.GetFileName(this.FileUpload1.PostedFile.FileName);
        //if (strFileFullName.Length > 0)
        //{
        //    if (FileUpload1.HasFile)
        //    {
        //        string newFileName = GetNewFileName(strFileFullName);
        //        string path_im = System.Web.HttpContext.Current.Server.MapPath（"[服务器端存储图片的路径]"  + newFileName);
        //        string pathSaveImg = Server.MapPath（"[服务器端存储图片的路径]"  + newFileName);
        //        this.FileUpload1.SaveAs(path);
             
        //        string tjImage_server = "[服务器端存储图片的路径]" + newFileName;
        //    }
        //    else
        //    {
        //        Response.Write("<script>alert('找不到该图片！')</script>");
        //    }
        //}


        //-----------------------------------------------------------------------------/
        string tjId = TextBox1.Text.Trim();
        string tjDate = TextBox2.Text.Trim();
        string tjTitle = TextBox3.Text.Trim();
        string tjText = TextBox4.Text.Trim();
        string tjImage = "./Images/" + fileImageNo;


        if ((tjId.Length == 0) || (tjDate.Length == 0) || (tjTitle.Length == 0) || (tjText.Length == 0) || (tjImage.Length == 0))
        {
            Response.Write("<script>alert('所有信息都为必填项，请检查是否漏填！')</script>");
        }
        string str = "insert into general_TeamJournalism values('" + tjId + "','" + tjDate + "','" + tjTitle + "','" + tjText + "','" + tjImage + "');";
        MysqlHelper.ExecuteNonQuery(str);

        Response.Redirect("./动态管理页面.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("./动态管理页面.aspx");
    }




//跟据文件名产生一个由时间+随机数组成的一个新的文件名 
//因为客户端上传的文件很可能会重名，所以要对文件名进行重命名
    public static string GetNewFileName(string FileName)
    {
        Random rand = new Random();

        string newfilename = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "m" +
         DateTime.Now.Day.ToString() + "d"
        + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString()
        + DateTime.Now.Millisecond.ToString()
            + "a" + rand.Next(1000).ToString()
        + FileName.Substring(FileName.LastIndexOf("."), FileName.Length - FileName.LastIndexOf("."));
        return newfilename;
    }
}