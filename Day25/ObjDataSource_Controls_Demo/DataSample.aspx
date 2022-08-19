﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataSample.aspx.cs" Inherits="ObjectDatasourceControls_Demo.DataSample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="EnterState"></asp:Label>
            &nbsp&nbsp&nbsp&nbsp
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp&nbsp&nbsp&nbsp
            <%--<asp:Button ID="Button1" runat="server" Text="Button" />--%>

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                <Columns>
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAuthorsByState" TypeName="ObjectDatasourceControls_Demo.Publisher">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" Name="state" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>

        </div>
    </form>
</body>
</html>
