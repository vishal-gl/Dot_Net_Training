<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="New_Demo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="New_Demo.Employee" EntityTypeName="" Select="new (EmployeeID, LastName, FirstName, Title, BirthDate, City)" TableName="Employees">
            </asp:LinqDataSource>
        </div>
    </form>
</body>
</html>
