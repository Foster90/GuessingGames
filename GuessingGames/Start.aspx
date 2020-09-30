<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="GuessingGames.Start" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="background-color:#97dcdf">
        <h1>Pandona's Guessing Game</h1>
        <p class="lead">Can you guess the number?</p>
       
       
  <div class="row">
    <div class="col-md-3">
       <br><p> Select the difficultly: <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList></p>
        <p>            
            <asp:Button ID="Start_Button" runat="server" class="btn btn-primary btn-lg" Text="Start >>" OnClick="Start_Button_Click" />
        </p>
       
        </div>
    
    <div class="col-md-3">
        
            
        </div>

      <div class="col-md-3">
                <img src="gifs/box.gif" style="width: 480px; height: 360px" />

       </div>
  </div>
</div>   
 

       
        
</asp:Content>
