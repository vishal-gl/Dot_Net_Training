<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SDetails.aspx.cs" Inherits="Student_Database.SDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 0px;
        }
        .auto-style2 {
            width: 120%;
        }
        .auto-style3 {
            margin-bottom: 0px;
            margin-left: 239px;
        }
        .auto-style4 {
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <td>


        </td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" BorderWidth="2px" CssClass="auto-style3" ForeColor="Black" Text="           Student Data" Width="135px"></asp:Label>
        <br />
        <br />
       
        <div>
            <table class="auto-style2">
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="SId"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;- &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" BorderWidth="2px" CssClass="auto-style1" ></asp:TextBox>
                       &nbsp;&nbsp;&nbsp; <asp:Button ID="Button5" runat="server" Text="Get" OnClick="Button5_Click" BorderWidth="3px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">

            <asp:Label ID="Label1" runat="server" Text="SName"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" BorderWidth="2px"></asp:TextBox>
                    </td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td>
            <asp:Label ID="Label4" runat="server" Text="Age"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" BorderWidth="2px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
            <asp:Label ID="Label5" runat="server" Text="Standard"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" BorderWidth="2px"></asp:TextBox>

                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
        <asp:Label ID="Label2" runat="server" Text="Address"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" BorderWidth="2px"></asp:TextBox>

                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
        <asp:Label ID="Label6" runat="server" Text="CourseId"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" BorderWidth="2px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
        </div>
        <div>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
        </div>
        <br />

        <div>

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" BorderWidth="3px" />
&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Display" BorderWidth="3px" />



            &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" BorderWidth="3px" OnClick="Button3_Click" Text="Update" />
&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="Button3" runat="server" BorderWidth="3px" OnClick="Button4_Click" Text="Delete" OnClientClick="Are You Sure Want To Delete?" />





            &nbsp;&nbsp;&nbsp;<br />
            <br />
            &nbsp;&nbsp;





            <asp:GridView ID="GridView1" runat="server"  OnRowDeleting="GridView1_RowDeleting" DataKeyNames="Id" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>

                    
                    <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" ShowHeader="True" />
                    <asp:CommandField HeaderText="Edit" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True" />

                    
                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>


            <br />


        </div>
    </form>
</body>
</html>
