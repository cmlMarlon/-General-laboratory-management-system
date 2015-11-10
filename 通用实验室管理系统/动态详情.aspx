<%@ Page Language="C#" AutoEventWireup="true" CodeFile="动态详情.aspx.cs" Inherits="动态详情" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="taDate_title" runat="server" Text="时间日期："></asp:Label>
        <asp:Label ID="taDate" runat="server"></asp:Label><br />

        <asp:Label ID="taTitle_title" runat="server" Text="标 题："></asp:Label> &nbsp
        <asp:Label ID="taTitle" runat="server"></asp:Label><br />

        <asp:Label ID="taText_title" runat="server" Text="新闻内容："></asp:Label>
        <asp:Label ID="taText" runat="server"></asp:Label><br />

          <asp:Label ID="taImage_title" runat="server" Text="新闻图片："></asp:Label>
            <asp:Image ID="taImage" runat="server" />
        <br />
    </div>
    </form>
</body>
</html>
