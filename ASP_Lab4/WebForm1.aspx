<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP_Lab4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="FirstNumber" runat="server"></asp:Label>
            <asp:Label ID="Operation" runat="server"></asp:Label>
            <asp:Label ID="SecondNumber" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Result"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Result" runat="server" OnTextChanged="Result_TextChanged" AutoPostBack="True"></asp:TextBox>
            <asp:Label ID="CorrectResult" runat="server" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="Message" runat="server" Text="Try again, please" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="Reset" runat="server" OnClick="Reset_Click" Text="Reset" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Results" runat="server" Text="Results" OnClick="Results_Click" style="height: 26px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Mistakes" runat="server" Text="Mistakes" OnClick="Mistakes_Click" Width="81px" />
            <br />
            <br />
            <asp:Label ID="CorrectResultLabel" runat="server" Text="Correct results count" Visible="False"></asp:Label>
            <asp:Label ID="CorrectResultsCount" runat="server" Visible="False"></asp:Label>
            <asp:HiddenField ID="HiddenResultsCount" runat="server" />
        </div>
    </form>
</body>
</html>
