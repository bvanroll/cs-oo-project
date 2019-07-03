<%@ Page Language="C#" Inherits="Gui.Admin" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Admin</title>
</head>
<body>
	<form id="form1" runat="server">
            <asp:Button id="addUser" OnClick="addUser_Click" runat="server" Text="addUser"/>
            <asp:Button id="addMatch" OnClick="addMatch_Click" runat="server" Text="addMatch"/>
            <asp:Button id="addPloeg" OnClick="addPloeg_Click" runat="server" Text="addPloeg"/>
            <p>games:</p>
            <asp:ListBox id="listGames" runat="server"/>
            <asp:Button id="updateGame" OnClick="updateGame_Click" runat="server" Text="updateGame"/>
	</form>
</body>
</html>
