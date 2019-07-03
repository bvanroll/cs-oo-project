<%@ Page Language="C#" Inherits="Gui.addBet" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>addBet</title>
</head>
<body>
	<form id="form1" runat="server">
            <asp:Label id="gameinfo" runat="server"/>
            <p>Amount</p>
            <asp:TextBox id="amount" runat="server"/>
            <p>on</p>
            <asp:DropDownList id="teams" runat="server"/>
            <p>BetType</p>
            <asp:DropDownList id="type" runat="server"/>
            <asp:Label id="lblStatus" runat="server"/>
            <asp:Button id="PlaceBet" runat="server" OnClick="placeBet"/>
            <asp:Button id="cancel" runat="server" OnClick="ret"/>
	</form>
</body>
</html>
