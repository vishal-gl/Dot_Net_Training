<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="ServerObjects_Demo.FirstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Welcome to server Objects</h2>
        <div>
            <table style="width:70%;">
                <tr>
                    <td>
                    Redirect within the Same Application
                    </td>&nbsp;
                    <td>

                        &nbsp;<asp:Button ID="Button1" runat="server" Text="Response.Redirect" OnClick="Button1_Click"/>
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Server.Transfer" OnClick="Button2_Click"/>

                    </td>

                </tr>
                
                
                <br />
                <td>
                    Redirect within the&nbsp;Outside Application
                </td>&nbsp;
                <td>

                    &nbsp;<asp:Button ID="Button3" runat="server" Text="Response.Redirect" OnClick="Button3_Click"/>
                 </td>
                 <td>
                    <asp:Button ID="Button4" runat="server" Text="Server.Transfer" OnClick="Button4_Click"/>

                 </td>


                
            </table>
        </div>
    </form>
</body>
</html>
