<%@ Page Language="C#" AutoEventWireup="true" CodeFile="人员管理.aspx.cs" Inherits="人员管理" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
  <meta http-equiv="Pragma" content="no-cache" />
  <meta http-equiv="Cache-Control" content="no-cache" />
  <meta http-equiv="Expires" content="0" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="添加" Width="100px" OnClick="Button1_Click" />
    
    </div>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" AllowPaging="True" Width="1221px" DataKeyNames="pId" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnPageIndexChanging="GridView1_PageIndexChanging"   >
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            <Columns>
                <asp:BoundField DataField="pId" HeaderText="序号" ReadOnly="True" />
                <asp:BoundField DataField="pName" HeaderText="姓名" />
                <asp:BoundField DataField="pSex" HeaderText="性别" />
                <asp:BoundField DataField="pAddress" HeaderText="地址" />
                <asp:BoundField DataField="pWorkingsState" HeaderText="实验室职位" />
                <asp:BoundField DataField="pWorkingsState" HeaderText="工作状态" />
                <asp:BoundField DataField="Pay" HeaderText="工资" />
                <asp:TemplateField HeaderText="查询参与项目">
                    <ItemTemplate>
                        <asp:Button ID="Button2" runat="server" OnClick="search" Text="查询" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" HeaderText="编辑" />
                <asp:CommandField ShowDeleteButton="True" HeaderText="删除" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
