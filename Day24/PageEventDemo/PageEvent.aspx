<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageEvent.aspx.cs" Inherits="PageEventDemo.PageEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Controls Being Minitored For Change Events:</h1>
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True"  OnTextChanged="CtrlChanged"></asp:TextBox>
            <br />
            <br />




            <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CtrlChanged" AutoPostBack="true" Text="Just Check it" /> &nbsp;&nbsp;

            <br />
            <br />


            


            <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="true" GroupName="Sample" Text="Radio Button 1"  OnCheckedChanged="CtrlChanged"/><br />

            <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="true" GroupName="Sample" Text="Radio Button 2"  OnCheckedChanged="CtrlChanged"/><br />

            <h3>List Of Boxes</h3>
            <asp:ListBox ID="ListBox1" runat="server" Width="200px " Height="200px"></asp:ListBox><br />



            

        </div>
    </form>
</body>
</html>
