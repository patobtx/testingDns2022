<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="testingDns2022._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Homepage</h1> <br />
        ~IP Testing~<br />
         <br />
        <asp:Label ID="lblIpResult" runat="server" BorderStyle="Solid"></asp:Label>

        <br />
        ~Testing~<br />
        <br />
        <asp:Label ID="lblResult" runat="server" BorderStyle="Solid"></asp:Label>
        <br />
        ~Sleep 5s -> Test 2~ <br /><br />
        <asp:Label ID="lblResult2" runat="server" BorderStyle="Solid"></asp:Label>

    </div>



</asp:Content>
