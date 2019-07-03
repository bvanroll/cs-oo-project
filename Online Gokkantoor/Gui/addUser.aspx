<%@ Page Language="C#" Inherits="Gui.addUser" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>addUser</title>
</head>
<body>
	<form id="form1" runat="server">
            <p>Naam</p>
            <asp:TextBox id="txtName" runat="server"/>
            <p>Achternaam</p>
            <asp:TextBox id="txtLastName" runat="server"/>
            <p>addr</p>
            <asp:TextBox id="txtAddr" runat="server"/>
            <p>gsm</p>
            <asp:TextBox id="txtGsm" runat="server"/>
            <p>balans</p>
            <asp:TextBox id="txtBalance" runat="server"/>
            <asp:Label id="alertlabel" runat="server" />
            <asp:Button id="addusr" OnClick="test" runat="server" Text="Add User"/>
            <p></p>
            <asp:Button id="return" OnClick="ret" runat="server" Text="Return"/>
	</form>
</body>
</html>
