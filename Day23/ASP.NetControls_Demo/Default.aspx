<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP.NetControls_Demo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset style="width: 300px">
                <legend>Reset CheckBox</legend>
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Checkbox1" />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Checkbox2" />
            </fieldset>
            <fieldset style="width: 300px">
                <legend>Reset CheckBoxList</legend>
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatColumns="4" RepeatDirection="Horizontal">
                    <asp:ListItem>Item1</asp:ListItem>
                    <asp:ListItem>Item2 </asp:ListItem>
                    <asp:ListItem>Item3 </asp:ListItem>
                    <asp:ListItem>Item4 </asp:ListItem>
                </asp:CheckBoxList>
            </fieldset>
            <fieldset style="width: 300px">
                <legend>Clear TextBox</legend>
                <asp:TextBox ID="TextBox1" runat="server" Width="140px"></asp:TextBox>
                <asp:TextBox ID="TextBox2" runat="server" Width="140px"></asp:TextBox>
            </fieldset>
            <fieldset style="width: 300px">
                <legend>Reset DropDownList</legend>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>-- Select --</asp:ListItem>
                    <asp:ListItem>Item1</asp:ListItem>
                    <asp:ListItem>Item2 </asp:ListItem>
                    <asp:ListItem>Item3 </asp:ListItem>
                    <asp:ListItem>Item4 </asp:ListItem>
                </asp:DropDownList>

            </fieldset>
            <fieldset style="width: 300px">
                <legend>Reset RadioButton</legend>
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Radiobutton" />
            </fieldset>
            <fieldset style="width: 300px">
                <legend>Reset RadioButtonList</legend>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatColumns="4" RepeatDirection="Horizontal">
                    <asp:ListItem>Item1</asp:ListItem>
                    <asp:ListItem>Item2</asp:ListItem>
                    <asp:ListItem>Item3</asp:ListItem>
                    <asp:ListItem>Item4</asp:ListItem>
                </asp:RadioButtonList>
            </fieldset>
            <fieldset style="width: 300px">
                <legend>Reset Label Text</legend>
                <asp:Label ID="Label1" runat="server" Text="label1 text"></asp:Label>&nbsp;&nbsp
                <asp:Label ID="Label2" runat="server" Text="label2 text"></asp:Label>
            </fieldset>
            <asp:HiddenField ID="HiddenField1" runat="server" Value="123" />
            <br />
            <asp:Button ID="btnReset" runat="server"
                Text="Reset controls" OnClick="btnReset_Click" />
        </div>
    </form>
</body>
</html>
