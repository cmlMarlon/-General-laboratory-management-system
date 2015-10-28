<%@ Page Language="C#" AutoEventWireup="true" CodeFile="后台管理页面.aspx.cs" Inherits="首页" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <title></title>
    <style type="text/css">
        .menubutton {
            width: 60%; 
            height:5%;
            margin-left:25%;
            margin-top:10%
        }
        .menubutton2{
            width: 60%; 
            height:3%;
            margin-left:30%;
            margin-top:3%;
        }
    </style>
    <script src="js/jquery-1.7.1.min.js" type="text/javascript"></script>  
    <script type="text/javascript">
        function forvisible() {
            var iDiv = document.getElementById("jingfei_title2");
            if (iDiv) {
                if (iDiv.style.display == "block") {
                    iDiv.style.display = "none";
                }
                else {
                    iDiv.style.display = "block";
                }
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server" style="height:800px">
    <div style="height: 10%">
    
    </div>
        <div style="width: 20%; height: 80%; background:red; float:left;" >
            <a href="资产管理页面.aspx" target="rightdiv">
                <input type="button" value="资产管理页面"class="menubutton" style="margin-top:25%" />
            </a>
            <a href="动态管理页面.aspx" target="rightdiv">
                <input type="button" value="动态管理页面" class="menubutton" />
            </a>
            <a href="人员管理页面.aspx" target="rightdiv">
                <input type="button" value="人员管理页面" class="menubutton" />
            </a>
            <a href="实验室管理页面.aspx" target="rightdiv">
                <input type="button" value="实验室管理页面" class="menubutton" />
            </a>
                <input type="button" value="经费管理页面" runat="server" class="menubutton" id="jingfei" onclick="forvisible()"/>
              <div id="jingfei_title2" style="display:none">
              <a href="经费管理页面.aspx" target="rightdiv">
                 <input type="button" value="经费管理页面下属1" class="menubutton2" />
              </a>
              <a href="经费管理页面.aspx" target="rightdiv">
                 <input type="button" value="经费管理页面下属2" class="menubutton2" />
              </a>
            </div>
            <a href="项目管理页面.aspx" target="rightdiv">
                <input type="button" value="项目管理页面" class="menubutton"  />
            </a>
        </div>
        <div id="rightdiv" style=" width:80%; float:right; height: 80%; background:blue" >
            <iframe name="rightdiv" style="height: 100%; width: 100%"></iframe>

        </div>
        <div style=" height:10%;">

        </div>
    </form>
</body>
</html>
