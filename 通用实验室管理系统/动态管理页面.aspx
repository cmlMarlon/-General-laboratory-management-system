<%@ Page Language="C#" AutoEventWireup="true" CodeFile="动态管理页面.aspx.cs" Inherits="动态管理页面" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width:49%; float:left; height:800px; background-color:;">
        <h1>新闻动态</h1><br />
       <a href="新闻添加.aspx"><asp:Button ID="添加新新闻" runat="server" Text="添加新新闻" /></a> &nbsp
        &nbsp
        <asp:Button ID="新闻查询" runat="server" Text="新闻查询" OnClick="新闻查询_Click" /> 
        <asp:TextBox ID="新闻查询框" runat="server" value="请输入标题" style ="color:#808080" onfocus="javascript:if(this.value == '请输入标题') this.value=''; else style='color:#000'" onBlur="javascript:if(this.value=='') this.value='请输入标题';" ></asp:TextBox>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="tjId" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="tjId" HeaderText="编号" ReadOnly="True" />
                <asp:BoundField DataField="tjDate" HeaderText="日期">
                    <HeaderStyle Width="20%" />
                </asp:BoundField>
                <asp:BoundField DataField="tjTitle" HeaderText="新闻标题" >
                    <HeaderStyle Width="40%" />
                </asp:BoundField >
                <asp:HyperLinkField DataNavigateUrlFields="tjId" DataNavigateUrlFormatString="新闻详情.aspx?id={0}" HeaderText="查看详情" Text="详细" />
                <asp:CommandField HeaderText="删除" ShowDeleteButton="True" ShowHeader="True">
                     <HeaderStyle Width="10%" />
                </asp:CommandField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
    <div style="width:49%; float:right; height:800px; background-color:yellow">
        <h1>活动动态</h1><br />
       <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" Width="100%">
            <Columns>
                <asp:BoundField DataField="taId" HeaderText="编号" ReadOnly="True" />
<asp:BoundField DataField="taDate" HeaderText="日期"></asp:BoundField>
                <asp:BoundField DataField="taTitle" HeaderText="新闻标题" >
                    <HeaderStyle Width="40%" />
                </asp:BoundField >
                <asp:HyperLinkField DataNavigateUrlFields="taId" DataNavigateUrlFormatString="动态详情.aspx?id={0}" HeaderText="查看详情" Text="详细" />
            </Columns>
        </asp:GridView>
    </div>
        
    </form>
</body>
</html>
