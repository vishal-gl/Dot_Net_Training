<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="XML_DataSource_Demo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView runat="server" AutoGenerateColumns="False" DataKeyNames="roll" DataSourceID="SqlDataSource1" OnRowUpdated="Unnamed1_RowUpdated" OnSelectedIndexChanged="Unnamed1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="roll" HeaderText="roll" ReadOnly="True" SortExpression="roll" />
                    <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" />
                    <asp:BoundField DataField="AGE" HeaderText="AGE" SortExpression="AGE" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                    <asp:ButtonField CommandName="Edit" HeaderText="Edit" ShowHeader="True" Text="Edit" />
                    <asp:ButtonField CommandName="Delete" Text="Delete" />
                    <asp:ButtonField ButtonType="Button" CommandName="Update" HeaderText="Update" ShowHeader="True" Text="Update" />
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentConnectionString %>" SelectCommand="SELECT [roll], [NAME], [AGE], [City] FROM [STUDENTS]"></asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
