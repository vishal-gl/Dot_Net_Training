<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Presentation.aspx.cs" Inherits="Practice_Linq_Sql_3TierArchitecture.Presentation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Emp_Id"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Emp_Name"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Emp_Sal"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Dept_Id"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField HeaderText="Emp_Id" />
                <asp:BoundField HeaderText="Emp_Name" />
                <asp:BoundField HeaderText="Emp_sal" />
                <asp:BoundField HeaderText="Dept_Id" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
