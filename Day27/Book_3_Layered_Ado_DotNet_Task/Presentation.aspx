<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Presentation.aspx.cs" Inherits="Book_3_Layered_Ado_DotNet_Task.Presentation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table>
                    <tr>  
                        <td class="auto-style2">  
                            <asp:Label ID="lblId" runat="server" Text="Enter Book's Id"></asp:Label>  
                        </td>  
                        <td>  
                            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>  
                        </td>  
                    </tr>  
                    <tr>  
                        <td class="auto-style2">  
                            <asp:Label ID="lblName" runat="server" Text="Enter Book's Name"></asp:Label>  
                        </td>  
                        <td>  
                            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>  
                        </td>  
                    </tr>
                    <tr>  
                        <td class="auto-style2">  
                            <asp:Label ID="lblAuthor" runat="server" Text="Enter Author's Name"></asp:Label>  
                        </td>  
                        <td>  
                            <asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox>  
                        </td>  
                    </tr> 
                    <tr>  
                        <td class="auto-style2">  
                            <asp:Label ID="lblPublisher" runat="server" Text="Enter Publisher's Name"></asp:Label>  
                        </td>  
                        <td>  
                            <asp:TextBox ID="txtPublisher" runat="server"></asp:TextBox>  
                        </td>  
                    </tr>  
                    <tr>  
                        <td class="auto-style2">  
                            <asp:Label ID="lblPrice" runat="server" Text="Enter Book's Price"></asp:Label>  
                        </td>  
                        <td>  
                            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>  
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
                                onselectedindexchanging="gvDisplay_SelectedIndexChanging" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" CssClass="auto-style1" 
                                >  
                                <Columns>  
                                    <asp:BoundField DataField="Id" HeaderText="Id" />  
                                    <asp:BoundField DataField="Name" HeaderText="Name" />  
                                    <asp:BoundField DataField="Author" HeaderText="Author" />  
                                    <asp:BoundField DataField="Publisher" HeaderText="Publisher" />
                                    <asp:BoundField DataField="Price" HeaderText="Price" />
                                    
                                    <asp:CommandField ButtonType="Button" HeaderText="Edit"  SelectText="Edit" ShowSelectButton="True" />  
                                    <asp:TemplateField HeaderText="Delete">
     
                                        <ItemTemplate>  
                                            <asp:Button runat="server" ID="btnDelete"  OnClientClick="return confirm('Are you sure,you want to delete this record ?');" Text="Delete" CommandArgument='  
                                                <%# Eval("Id") %>' CommandName="Delete" />  
                                            </ItemTemplate>  
                                     </asp:TemplateField>  
                                    </Columns>  
                                <FooterStyle BackColor="White" ForeColor="#000066" />
                                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                <RowStyle ForeColor="#000066" />
                                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#00547E" />
                                </asp:GridView>  
                            </td>  
                        </tr>  
                    </table>  
       
        </div>
    </form>
</body>
</html>
