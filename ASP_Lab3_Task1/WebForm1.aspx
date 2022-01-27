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
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="The field should be not null" ControlToValidate="TextBox1"/>
            <asp:RangeValidator ID="RangeValidator1" Type="Integer" runat="server" ErrorMessage="The field should be at the range of 0 to 10" MinimumValue="0" MaximumValue="10" ControlToValidate="TextBox1"/>
        </div>

        <br />

        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
