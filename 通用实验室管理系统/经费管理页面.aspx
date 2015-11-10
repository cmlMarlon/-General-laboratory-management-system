<%@ Page Language="C#" AutoEventWireup="true" CodeFile="经费管理页面.aspx.cs" Inherits="经费管理页面" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="添加经费变化事件" Width="15%" OnClick="Button1_Click" />&nbsp
         <asp:Button ID="新闻查询" runat="server" Text="事件查询" Width="15%" OnClick="事件查询_Click" /> 
        <asp:TextBox ID="事件查询框" runat="server" value="请输入事件关键字" style ="color:#808080" Width="20%" onfocus="javascript:if(this.value == '请输入事件关键字') this.value=''; else style='color:#000'" onBlur="javascript:if(this.value=='') this.value='请输入事件关键字';" ></asp:TextBox>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" GridLines="None" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" OnRowDeleting="GridView1_RowDeleting" Width="100%"  AllowPaging="True" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnPageIndexChanging="GridView1_PageIndexChanging" DataKeyNames="fId">
            <Columns>
                <asp:BoundField DataField="fId" HeaderText="编号" ReadOnly="True" />
<asp:BoundField DataField="fFundBalance" HeaderText="经费余额总数"></asp:BoundField>
                <asp:BoundField DataField="fDate" HeaderText="日期" />
                <asp:BoundField DataField="fText" HeaderText="事件记录文档">
                    <HeaderStyle Width="40%" />
                </asp:BoundField>
                <asp:BoundField DataField="fFundChange" HeaderText="经费变化数" />
                <asp:BoundField DataField="fTeam" HeaderText="团队" ReadOnly="True" />
                <asp:CommandField HeaderText="编辑" ShowEditButton="True" />
                <asp:CommandField EditText="删除" HeaderText="删除" ShowDeleteButton="True" ShowHeader="True" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#333333"  />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
