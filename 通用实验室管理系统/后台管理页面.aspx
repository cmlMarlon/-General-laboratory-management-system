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

    </style>
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
            <a href="经费管理页面.aspx" target="rightdiv">
                <input type="button" value="经费管理页面" class="menubutton" />
            </a>
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
