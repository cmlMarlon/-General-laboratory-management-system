<%@ Page Language="C#" AutoEventWireup="true" CodeFile="添加人员.aspx.cs" Inherits="添加人员" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 362px;
        }
        .auto-style2 {
            width: 322px;
        }
        .auto-style3 {
            width: 362px;
            height: 22px;
        }
        .auto-style4 {
            width: 322px;
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center;">
        <table style="width: 400px;margin-top:120px; " align="center">
            <tr>
                <td class="auto-style1" style="text-align: right">
                <asp:Label ID="Label1" runat="server" Text="姓名："></asp:Label>
                </td>
                <td class="auto-style2">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align: right">
                <asp:Label ID="Label2" runat="server" Text="性别："></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align: right">
                <asp:Label ID="Label3" runat="server" Text="密码："></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align: right">
                <asp:Label ID="Label4" runat="server" Text="联系电话："></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align: right">
                <asp:Label ID="Label5" runat="server" Text="地址："></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="text-align: right">
                <asp:Label ID="Label6" runat="server" Text="从属实验室编号："></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align: right">
                <asp:Label ID="Label7" runat="server" Text="工作状态："></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align: right">
                <asp:Label ID="Label8" runat="server" Text="实验室职务："></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align: right">
                <asp:Label ID="Label9" runat="server" Text="工资："></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align: right">
                <asp:Label ID="Label10" runat="server" Text="实验室位子信息："></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="添加" Width="100px" OnClick="Button1_Click" />
                &nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="取消" Width="100px" OnClick="Button2_Click" />
                </td>
            </tr>

        </table>
    </div>
    </form>
</body>
</html>
