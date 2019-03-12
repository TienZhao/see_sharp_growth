<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeworkStringOffset.aspx.cs" Inherits="HelloWorld.homeworkStringOffset" %>

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
        <p>
            <asp:TextBox ID="txtOffset" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnStart" runat="server" OnClick="btnStart_Click" Text="Start" />
        <p>
            <asp:TextBox ID="txtOutput" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
