<%@ Page Language="C#" Inherits="Gui.mainForm" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>mainForm</title>
</head>
<body>
	<form id="form1" runat="server">
            <asp:Label runat="server" id="labelNaam"/>
            <asp:Label id="labelAdress" runat="server"/>
            <asp:Label id="labelGsm" runat="server"/>
            <asp:Label id="labelBalance" runat="server"/>
            <asp:Button id="btnAddBalance" runat="server" Text="add balance" OnClick='btnAddBalance_Click'/>
            <asp:Label id="labelTitleGamebox" runat="server" />
            <asp:ListBox id ="listGames" runat="server"/>
            <asp:Button id="btnPlaceBet" runat="server" Text="Place Bet On Selected Game" OnClick="placeBet_Click"/>
            <p>your current bets:</p>
            <asp:ListBox id="listBets" runat="server"/>
            
	</form>
</body>
</html>
