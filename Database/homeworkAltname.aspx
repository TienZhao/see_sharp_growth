<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeworkAltname.aspx.cs" Inherits="Database.homeworkAltname" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="查找曾用名" />
    </form>
</body>
</html>
