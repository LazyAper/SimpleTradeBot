<%@ Page Async="true" Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Startbot.aspx.cs" Inherits="SimpleTradeBotAsp4.About" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Запуск бота</h3>
        <p>Бот запущен</p>
         <% 
             SimpleTradeBotAsp4.Jobs.TradeBotScheduler.Start();
             %>
    </main>
</asp:Content>
