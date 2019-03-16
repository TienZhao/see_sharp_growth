<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeworkID.aspx.cs" Inherits="HelloWorld.homeworkID" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblInstruction" runat="server" Text="请输入需要校验的身份证号："></asp:Label>
        </div>
        <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnVerify" runat="server" OnClick="btnVerify_Click" style="height: 21px" Text="校验" />
        </p>
    </form>
</body>
</html>
