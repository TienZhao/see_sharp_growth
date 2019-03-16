<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeworkSqrt.aspx.cs" Inherits="HelloWorld.homeworkSqrt" %>

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
        <asp:Label ID="Label1" runat="server" Text="被开方数"></asp:Label>
        <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="步进次数"></asp:Label>
            <asp:TextBox ID="txtStep" runat="server" Height="19px"></asp:TextBox>
        </p>
        <asp:Button ID="btnStart" runat="server" OnClick="btnStart_Click" Text="开始" />
    </form>
</body>
</html>
