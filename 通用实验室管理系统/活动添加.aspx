<%@ Page Language="C#" AutoEventWireup="true" CodeFile="活动添加.aspx.cs" Inherits="活动添加" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div style="padding-left:40%">
        <label for="TextBox1" style="padding-right:32px">编号：</label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        &nbsp;&nbsp; 无需求可不填<br />
        <label for="TextBox2">新闻时间：</label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <label for="TextBox3">新闻标题：</label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <label for="TextBox4">新闻内容：</label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <label for="TextBox4" style="padding-right:32px">图片：</label>
          <asp:FileUpload ID="FileUpload1" runat="server" />
        <br /><br />
        <asp:Button ID="Button1" runat="server" Text="添加" Width="15%" OnClick="Button1_Click" />
        &nbsp&nbsp&nbsp
        <asp:Button ID="Button2" runat="server" Text="取消" Width="15%" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
