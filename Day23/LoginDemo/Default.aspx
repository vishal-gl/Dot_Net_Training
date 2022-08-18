<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LoginDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 58px;
        }
    </style>
</head>
<body bgcolor="White" text="#ccccc">
    <form id="form2" runat="server">
    <table style="width: 22%;">
        <tr>
            <td>
                User Name
                <br />
                <br />
            </td>

                
            <td>
                <asp:TextBox ID="TextBox1" runat="server"  
                ToolTip="Enter User Name" Width="128px"></asp:TextBox>
                
            </td>   
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password </td>
            <td class="auto-style1">
               <asp:TextBox ID="TextBox2" runat="server"  MaxLength="10" 
                 TextMode="Password"  ToolTip="Enter Password" Width="128px"></asp:TextBox>      
             </td>
            
        </tr> 
        <tr> 
        <td> 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btn1" runat="server" Text="Login" onclick="Button1_Click" />
           
            </td> 
        <td>

            <br /> &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btn2" runat="server" Text="Reset" onclick="Button2_Click" />
           
            
                
            &nbsp;<br />
            <br />
           
       </td>
 </tr>    
    </table>
    
        
        <p> 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#CC0000"></asp:Label></p>    
    
        
    </form>
</body>
</html>
