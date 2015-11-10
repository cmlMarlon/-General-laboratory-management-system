<%@ Page Language="C#" AutoEventWireup="true" CodeFile="新闻详情.aspx.cs" Inherits="新闻详情" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <script type="text/javascript">
            function forvisible() {
                var iDiv1 = document.getElementById("xinwen_xiugai");
                var iDiv2 = document.getElementById("xinwen_xianshi");
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
    <div id="xinwen_xiugai" style="display:none">
       <%-- <asp:Button ID="显示新闻" runat="server" Text="显示新闻"  OnClick="forvisible()" /><br />--%>
         <input type="button" value="显示新闻" runat="server" id="显示新闻" onclick="forvisible()"/>&nbsp&nbsp
         <asp:Button ID="提交修改" runat="server" Text="提交修改" /><br />
        <asp:Label ID="tjLabel1" runat="server" Text="时间日期：" for="tjdateBox" Width="150px"  ></asp:Label>
        <asp:TextBox ID="tjdateBox" runat="server" ></asp:TextBox><br />

        <asp:Label ID="tjLabel2" runat="server" Text="标 题：" for="tjtitleBox" Width="150px" ></asp:Label>
        <asp:TextBox ID="tjtitleBox" runat="server"></asp:TextBox><br />

        <asp:Label ID="tjLabel3" runat="server" Text="新闻内容：" for="tjtextBox"  Width="150px" ></asp:Label>
        <br />
        <asp:TextBox ID="tjtextBox" runat="server" TextMode="MultiLine" Width="80%" height="100%"></asp:TextBox><br />

          <asp:Label ID="tjLabel4" runat="server" Text="新闻图片:" for="FileUpload1" Width="150px"  ></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" />
     </div>
     <div id="xinwen_xianshi" style="display:block">
          <input type="button" value="修改新闻" runat="server" id="修改新闻" onclick="forvisible()"/><br />
        <asp:Label ID="tjDate_title" runat="server" Text="时间日期："></asp:Label>
        <asp:Label ID="tjDate" runat="server" Text="111" ></asp:Label><br />

        <asp:Label ID="tjTitle_title" runat="server" Text="标 题："></asp:Label> &nbsp
        <asp:Label ID="tjTitle" runat="server"></asp:Label><br />

        <asp:Label ID="tjText_title" runat="server" Text="新闻内容："></asp:Label><br />
        <asp:Label ID="tjText" runat="server"></asp:Label><br />

          <asp:Label ID="tjImage_title" runat="server" Text="新闻图片："></asp:Label>
            <asp:Image ID="tjImage" runat="server" />
        <br />
    </div>

    </form>
</body>
</html>
