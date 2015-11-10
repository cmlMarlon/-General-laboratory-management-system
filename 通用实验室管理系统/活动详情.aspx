<%@ Page Language="C#" AutoEventWireup="true" CodeFile="活动详情.aspx.cs" Inherits="活动详情" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <script type="text/javascript">
            function forvisible() {
                var iDiv1 = document.getElementById("huodong_xiugai");
                var iDiv2 = document.getElementById("huodong_xianshi");
                if (iDiv1) {
                    if (iDiv1.style.display == "block") {
                        iDiv1.style.display = "none";
                    }
                    else {
                        iDiv1.style.display = "block";
                    }
                }
                if (iDiv2) {
                    if (iDiv2.style.display == "block") {
                        iDiv2.style.display = "none";
                    }
                    else {
                        iDiv2.style.display = "block";
                    }
                }
            }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="huodong_xiugai" style="display:none">
         <input type="button" value="显示活动" runat="server" id="显示活动" onclick="forvisible()"/>&nbsp&nbsp
         <asp:Button ID="提交修改" runat="server" Text="提交修改" OnClick="提交修改_Click" /><br />
        <asp:Label ID="taLabel1" runat="server" Text="时间日期：" for="tjdateBox" Width="150px"  ></asp:Label>
        <asp:TextBox ID="tadateBox" runat="server" autopostback="true"></asp:TextBox><br />

        <asp:Label ID="taLabel2" runat="server" Text="标 题：" for="tjtitleBox" Width="150px" ></asp:Label>
        <asp:TextBox ID="tatitleBox" runat="server" autopostback="true"></asp:TextBox><br />

        <asp:Label ID="taLabel3" runat="server" Text="活动内容：" for="tjtextBox"  Width="150px" ></asp:Label>
        <br />
        <asp:TextBox ID="tatextBox" runat="server" TextMode="MultiLine" Width="80%" height="100%"  autopostback="true"></asp:TextBox><br />

          <asp:Label ID="taLabel4" runat="server" Text="活动图片:" for="FileUpload1" Width="150px"  ></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" autopostback="true" />
     </div>
     <div id="huodong_xianshi" style="display:block">
          <input type="button" value="修改活动" runat="server" id="修改活动" onclick="forvisible()"/><br />
        <asp:Label ID="taDate_title" runat="server" Text="时间日期："></asp:Label>
        <asp:Label ID="taDate" runat="server" Text="111" ></asp:Label><br />

        <asp:Label ID="taTitle_title" runat="server" Text="标 题："></asp:Label> &nbsp
        <asp:Label ID="taTitle" runat="server"></asp:Label><br />

        <asp:Label ID="taText_title" runat="server" Text="活动内容："></asp:Label><br />
        <asp:Label ID="taText" runat="server"></asp:Label><br />

          <asp:Label ID="taImage_title" runat="server" Text="活动图片："></asp:Label>
            <asp:Image ID="taImage" runat="server" />
        <br />
    </div>

    </form>
</body>
</html>
