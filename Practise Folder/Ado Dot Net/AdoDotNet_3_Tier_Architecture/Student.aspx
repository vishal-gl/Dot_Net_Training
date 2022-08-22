<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="AdoDotNet_3_Tier_Architecture.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Registration</title>
    <style type="text/css">
        .auto-style1 {
            margin-right: 208px;
        }
        .auto-style2 {
            width: 602px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                    <tr>  
                        <td class="auto-style2">  
                            <asp:Label ID="lblId" runat="server" Text="Enter Id"></asp:Label>  
                        </td>  
                        <td>  
                            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>  
                        </td>  
                    </tr>  
                    <tr>  
                        <td class="auto-style2">  
                            <asp:Label ID="lblName" runat="server" Text="Enter Name"></asp:Label>  
                        </td>  
                        <td>  
                            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>  
                        </td>  
                    </tr>  
                    <tr>  
                        <td class="auto-style2">  
                            <asp:Label ID="lblAge" runat="server" Text="Enter Age"></asp:Label>  
                        </td>  
                        <td>  
                            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>  
                        </td>  
                    </tr>  
                    <tr>  
                        <td class="auto-style2">  
                            <asp:Label ID="lblAddress" runat="server" Text="Enter Address"></asp:Label>  
                        </td>  
                        <td>  
                            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>  
                        </td>  
                    </tr>  
                    <tr>  
                        <td class="auto-style2">  
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" onclick="btnSubmit_Click" />  
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="Button1" runat="server"  OnClick="Button1_Click" Text="Display" />
                            <br />
                            <br />
                            <br />
                        </td>  
                    </tr>  
                    <tr>  
                        <td class="auto-style2">  
                            <asp:GridView ID="gvDisplay" runat="server" AutoGenerateColumns="False"  
                                  
                                onrowcommand="gvDisplay_RowCommand" onrowdeleting="gvDisplay_RowDeleting"  
                                onselectedindexchanging="gvDisplay_SelectedIndexChanging" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" CssClass="auto-style1" ForeColor="Black" GridLines="Vertical" 
                                >  
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <Columns>  
                                    <asp:BoundField DataField="Id" HeaderText="Id" />  
                                    <asp:BoundField DataField="Name" HeaderText="Name" />  
                                    <asp:BoundField DataField="Address" HeaderText="Address" />  
                                    <asp:BoundField DataField="Age" HeaderText="Age" />  
                                    <asp:CommandField ButtonType="Button" HeaderText="Edit"  SelectText="Edit" ShowSelectButton="True" />  
                                    <asp:TemplateField HeaderText="Delete">
     
                                        <ItemTemplate>  
                                            <asp:Button runat="server" ID="btnDelete"  OnClientClick="return confirm('Are you sure,you want to delete this record ?');" Text="Delete" CommandArgument='  
                                                <%# Eval("Id") %>' CommandName="Delete" />  
                                            </ItemTemplate>  
                                     </asp:TemplateField>  
                                    </Columns>  
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>  
                            </td>  
                        </tr>  
                    </table>  
        </div>
    </form>
</body>
</html>
