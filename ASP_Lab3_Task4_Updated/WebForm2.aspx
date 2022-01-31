<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ASP_Lab3_Task4_Updated.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <%--<asp:CompareValidator ID="CompareValidator1" Type="Integer" Operator="GreaterThan" runat="server" ErrorMessage="CompareValidator" ControlToValidate="TextBox1" ControlToCompare="TextBox2"/>--%>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="The field should be not null" ControlToValidate="TextBox1"/>
            <br />

            <asp:Label ID="Label2" runat="server" Text="Middle name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label3" runat="server" Text="Last name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="The field should be not null" ControlToValidate="TextBox3"/>

            <br />

            <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="The field should be not null" ControlToValidate="TextBox4"/>
            <asp:RegularExpressionValidator ID="Email" runat="server" ValidationExpression="^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$" ControlToValidate="TextBox4" ErrorMessage="Invalid Email"/>
            <br />

            <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:TextBox ID="TextBox5" runat="server" AutoPostBack="True"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator10" runat="server" ErrorMessage="Invalid password" ControlToValidate="TextBox5" OnServerValidate="CustomValidator10_ServerValidate" Visible="true" EnableClientScript="False"/>
            
            <br />

            <asp:Label ID="Label5" runat="server" Text="Confirm Password"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="The field should be not null" ControlToValidate="TextBox6"/>
            <asp:CompareValidator ID="PasswordCompareValidator" runat="server" ErrorMessage="Pasword mismatch" ControlToValidate="TextBox6" ControlToCompare="TextBox5" />

            <br />

            <asp:Label ID="Label7" runat="server" Text="Age"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="The field should be not null" ControlToValidate="TextBox7"/>
            <asp:RangeValidator ID="AgeValidator1" Type="Integer" runat="server" ErrorMessage="The field should be in range of 18 to 99" MinimumValue="18" MaximumValue="99" ControlToValidate="TextBox7"/>
            <br />

            <asp:Label ID="Label8" runat="server" Text="Phone"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="The field should be not null" ControlToValidate="TextBox8"/>
            <asp:RegularExpressionValidator ID="PhoneValidator" runat="server" ErrorMessage="There is not phone number" ControlToValidate="TextBox8" ValidationExpression="^[+]*\([0-9]{3}\)\-[0-9]{2}\-[0-9]{3}\-[0-9]{2}\-[0-9]{2}$" />
            <br />

            <asp:Label ID="Label9" runat="server" Text="Address"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="The field should be not null" ControlToValidate="TextBox9"/>
            <asp:CustomValidator ID="LengthValidator1" runat="server" ErrorMessage="The field length should be greater than 20 symbols" ControlToValidate="TextBox9" OnServerValidate="LengthValidator1_ServerValidate"/>
            <br />
        </div>
    <br />

        <asp:Button ID="Button1" runat="server" Text="Add" Width="130px" OnClick="Button1_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Cancel" Width="115px" OnClick="Button2_Click" CausesValidation="False" />
        <h3 style="margin-left: 160px">

            <asp:Label ID="Label10" runat="server" Text="Success" Visible="False"></asp:Label>
        </h3>
    </form>
</body>
</html>
