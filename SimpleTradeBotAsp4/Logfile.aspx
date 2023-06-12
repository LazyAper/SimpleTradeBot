<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logfile.aspx.cs" Inherits="SimpleTradeBotAsp4.Logfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <%
        string readText = System.IO.File.ReadAllText("SimpleTradeBot.txt");
        %>

    <%:readText.Replace("\r\n", "<br />") %>
</body>
</html>
