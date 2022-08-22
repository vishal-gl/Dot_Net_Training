<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListBox.aspx.cs" Inherits="ListBox_Task.ListBox" %>

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
                    <td>  
                            

                        <asp:Label ID="Label1" runat="server" Text="Fruit_List_1"></asp:Label>
                            

                    </td>  
                    <td>
                        <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
                        <asp:ListItem>Apple</asp:ListItem>
                        <asp:ListItem>Banana</asp:ListItem>
                           <asp:ListItem>PineApple</asp:ListItem>
                        <asp:ListItem>Orange</asp:ListItem>
                        <asp:ListItem>Cherry</asp:ListItem>
                        </asp:ListBox>

                    </td>

                </tr>
                <br />
                <br />
                <tr>
                    <td>

                        <asp:Label ID="Label2" runat="server" Text="Fruit_List_2"></asp:Label>

                    </td>
                    <td>
                         <asp:ListBox ID="ListBox2" runat="server" SelectionMode="Multiple">
                         <asp:ListItem>Pomegranate</asp:ListItem>
                         <asp:ListItem>Apple</asp:ListItem>
                         <asp:ListItem>Grapes</asp:ListItem>
                         <asp:ListItem>Black Grapes</asp:ListItem>
                         <asp:ListItem>Orange</asp:ListItem>
                         </asp:ListBox>
                    </td>
                </tr>

            </table>
            
            
        </div>
        <div>

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Merge" OnClientClick="return confirm('Are you sure,you want to Merge this selected Item ?');" />

        </div>
       
    </form>
</body>
</html>
