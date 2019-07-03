<%@ Page Language="C#" Inherits="Gui.addMatch" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>addMatch</title>
</head>
<body>
	<form id="form1" runat="server">
            <p>leave score blank for non scores</p>
            <p>Ploeg1</p>
            <asp:DropDownList id="ploeg1" runat="server" />
            <p>score</p>
            <asp:TextBox id="score1" runat="server" />
            <p>Ploeg2</p>
            <asp:DropDownList id="ploeg2" runat="server" />
            <p>score</p>
            <asp:TextBox id="score2" runat="server" />
            
            <p>dag</p>
            <asp:DropDownList id="dag" runat="server"/>
            <p>maand</p>
            <asp:DropDownList id="maand" runat="server" />
            
            <p>year</p>
            <asp:DropDownList id="jaar" runat="server"/>
            <p>status:</p>
            <asp:Label id="statusLabel" runat="server" />
            <asp:Button id="matchadd" OnClick="matchadd_Click" runat="server"  Text="AddMatch"/>
            <asp:Button id="returnHome" OnClick="ret" runat="server" Text="Return home" />
            
            
	</form>
</body>
</html>
