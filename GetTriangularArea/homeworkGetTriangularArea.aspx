<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeworkGetTriangularArea.aspx.cs" Inherits="homeworkGetTriangularArea.homeworkGetTriangularArea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabInstruction" runat="server" Text="请在下方输入三角形的三边长度："></asp:Label>
        </div>
        <p>
            <asp:TextBox ID="txtA" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtB" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtC" runat="server"></asp:TextBox>
        </p>    
        <p>
            <asp:Button ID="btnGet" runat="server" Text="求三角形面积" OnClick="btnGet_Click1" />
        </p>
        <asp:TextBox ID="txtOut" runat="server" Height="50px" Width="600px"></asp:TextBox>
    </form>
</body>
</html>
