
<%@ Page Title="Product" Language="C#"  AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="NavigationDemo.Contact" %>

    


    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head >
        <title>Product</title>
        <style>
        body{
            margin: 0;
            font-family: Arial, Helvetica, sans-serif;
        }
        .navbar{
            overflow: hidden;
            background-color: #3c8bed;

        }
        .navbar a{
            float: left;
            color: #f2f2f2;
            text-align: center;
            padding: 18px 26px;
            text-decoration: none;
            font-size: 17px;
        }
        .navbar a:hover {
                background-color: #00ff90;
                color: black;
        }
        .navbar a.active {
                background-color: #04AA6D;
                color: yellow;
        }
         .navbar a.active:hover{
                background-color: Black;
                color:White
                
        }
        
        

        
        .navbar a:hover, .dropdown:hover .dropbtn {
            background-color: white;
        }
        

        
    </style>
       
  


    </head>

    <body>
    <form id="form1" runat="server">

        
        
        <div class="navbar">
            <a class="active" href="~/"><i>Products</i></a>
            <a href="~/Grocery">Grocery</a>
            <a href="#">Electronics</a>
            <a href="#">Accessories</a>
            <a href="#">Stationary</a>
            <a href="#">Clothes</a>
                
               
            
            

        </div>
        <br />
        <br />
        <br />


        <td>
            <h2>Festive Season bring 15% Off on Clothes</h2>

        </td>
        <td>
            <src=
        </td>

        
  
                
        
    </form>
</body>
    </html>
