<%@ Page Language="C#" AutoEventWireup="true" CodeFile="经费事件添加.aspx.cs" Inherits="经费事件添加" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="padding-left:40%">
        <label for="TextBox1" style="padding-right:32px">编号：</label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        &nbsp;&nbsp; 无需求可不填<br />
        <label for="TextBox2">经费余额：</label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <label for="TextBox3" style="padding-right:32px">日期：</label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <label for="TextBox4">事件文档：</label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <label for="TextBox4">经费变化：</label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="添加" Width="15%" OnClick="Button1_Click" />
        &nbsp&nbsp&nbsp
        <asp:Button ID="Button2" runat="server" Text="取消" Width="15%" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
