<%@ Page Title="Game" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="GuessingGames.Game" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     


        <div class="jumbotron" style="background-color:#97dcdf">
        <h1>Pandora's Guessing Game</h1>
        <p class="lead">Can you guess what is in Pandora's box?</p>
       
       
  <div class="row">
    <div class="col-md-3">
       <br><p> Please Pick a number: <asp:TextBox ID="TextBox1" runat="server" Width="209px"></asp:TextBox></p>
        <p>            
            <asp:Button ID="Button1" runat="server"  class="btn btn-primary btn-lg" OnClick="Guess_Click" Text="Guess" Width="99px" />
            <asp:Button ID="Button2" runat="server"  class="btn btn-primary btn-lg" OnClick="Reset_Click" Text="Reset" Width="99px" />
        </p>
        <br>
        
          <asp:Label ID="Label1" runat="server" Text="" style= "font-size:26px;font-weight:bold"></asp:Label>
     <%--   style="color:#006600;font-size:26px;font-weight:bold"--%>
       
        </div>
    
    <div class="col-md-3">
          <asp:Label ID="Label3" runat="server" Text="Number of Guess left:" style= "font-size:26px;font-weight:bold" ></asp:Label>

          <p><asp:Label ID="Label2" runat="server" Text="Numbers Guessed: " style= "font-size:26px;font-weight:bold"  Visible="false"></asp:Label>
                         
        </div>

      <div class="col-md-3">
                <img src="gifs/box.gif" style="width: 480px; height: 360px" />

       </div>
  </div>

            
        

</div>   
         



</asp:Content>
