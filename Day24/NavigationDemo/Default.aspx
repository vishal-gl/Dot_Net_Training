<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NavigationDemo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <style>
body {
  background-image: url('img_girl.jpg');
  background-repeat: no-repeat;
  background-attachment: fixed;
  background-size: 100% 100%;
}
</style>>

        <h1>Shopify</h1>
        
        
            
        <p class="lead"></p>
        <p><a href="Signin.html" class="btn btn-primary btn-lg">Sign In &raquo;</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <a href="LoginPage.html" class="btn btn-primary btn-lg">Register &raquo;</a>
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Starts Your New Journey With Our Products</h2>
           
            <p>
                <a class="btn btn-default" href="Product.aspx">Search More &raquo;</a>
            </p>
        </div>
        
    </div>

</asp:Content>
