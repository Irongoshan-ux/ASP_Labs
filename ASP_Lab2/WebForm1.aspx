<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP_Lab2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Сумма кредита"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </div>
        <asp:Label ID="Label2" runat="server" Text="Процентная ставка"></asp:Label>
        <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Rows="1" Width="117px">
            <asp:ListItem>12</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="День выдачи кредита"></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <br />
        <asp:Label ID="Label4" runat="server" Text="День погашения кредита"></asp:Label>
        <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged"></asp:Calendar>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Посчитать" />
        <asp:Label ID="Label5" runat="server" Text="Сумма процентов по кредиту: " Visible="False"></asp:Label>
    </form>
</body>
</html>
