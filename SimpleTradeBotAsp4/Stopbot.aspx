<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Stopbot.aspx.cs" Inherits="SimpleTradeBotAsp4.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>>Бот остановлен</h3>

        <%SimpleTradeBotAsp4.Jobs.TradeBotScheduler.Stop(); %>
    </main>
</asp:Content>
