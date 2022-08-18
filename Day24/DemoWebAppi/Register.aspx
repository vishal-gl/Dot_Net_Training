<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="DemoWebAppi.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="White">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Text="Customer ID"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

        </div>
        <div>
            

            <asp:Label ID="Label1" runat="server" Text="Customer Name"></asp:Label> &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            

        </div>
        <div>


            

            <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="M">Male</asp:ListItem>
                <asp:ListItem Value="F">Female</asp:ListItem>
                <asp:ListItem Value="T">Other</asp:ListItem>
            </asp:DropDownList>


            

        </div>
        <div>

            <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

            <br />
            <asp:Label ID="Label5" runat="server" Text="Phone No."></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

        </div>
        <div> 
         
            &nbsp;&nbsp;<br />
            <asp:Button ID="Btn2" runat="server" Text="Add" />

            &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btn1" runat="server" Text="Update" />


            &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Display" />

            &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Delete" />



            



           
            
                
            
           
       
       </div>    
        

    </form>
</body>
</html>
