<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP_Lab3_Task1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" Type="Integer" Operator="GreaterThan" ValueToCompare="10" runat="server" ErrorMessage="CompareValidator" ControlToValidate="TextBox1"/>
            <%--<asp:CompareValidator ID="CompareValidator1" Type="Integer" Operator="GreaterThan" runat="server" ErrorMessage="CompareValidator" ControlToValidate="TextBox1" ControlToCompare="TextBox2"/>--%>
        </div>

        <br />

        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
