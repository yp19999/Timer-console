<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountDown.aspx.cs" Inherits="CountDown.CountDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="lblTime" runat="server" />
                <asp:Timer ID="Timer1" runat="server" OnTick="GetTime" Interval="1000" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
