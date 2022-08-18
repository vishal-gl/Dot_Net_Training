<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Loginapplication.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="White" text="#663300">
    <form id="form1" runat="server">
 <table style="width: 22%;">
        <tr>
            <td>
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           User Name
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"  
                ToolTip="Enter User Name" Width="128px"></asp:TextBox>
                
            </td>   
        </tr>
        <tr>
            <td>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             PassWord
            </td>
            <td>
               <asp:TextBox ID="TextBox2" runat="server"  MaxLength="10" 
                 TextMode="Password"  ToolTip="Enter Password" Width="128px"></asp:TextBox>      
             </td>
            <br/>
        </tr> 
        <tr> 
        <td>  &nbsp;</td> 
        <td>
            <asp:Button ID="btn1" runat="server" Text="Reset" onclick="Button1_Click" />
           
            &nbsp;&nbsp;
            <asp:Button ID="Btn2" runat="server" Text="Login" onclick="Button2_Click" />
           
       </td>
 </tr>    
    </table>
  
    <p> 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#CC0000"></asp:Label></p>    
     
    </form>

</body>
</html>
