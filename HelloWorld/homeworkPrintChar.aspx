<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeworkPrintChar.aspx.cs" Inherits="HelloWorld.homeworkPrintChar" %>

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
        <asp:Label ID="lblInstruction" runat="server" Text="请输入行号"></asp:Label>
        <asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnGo" runat="server" Height="21px" OnClick="btnGo_Click" Text="输出图形" />
        </p>
    </form>
</body>
</html>
