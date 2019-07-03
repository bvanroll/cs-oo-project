<%@ Page Language="C#" Inherits="Gui.updateGame" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>updateGame</title>
</head>
<body>
	<form id="form1" runat="server">
            <asp:Label id="thuis" runat="server"/>
            <asp:TextBox id="scoreThuis" runat="server"/>
            <asp:Label id="uit" runat="server"/>
            <asp:TextBox id="scoreUit" runat="server"/>
            <asp:Button id="finish" OnClick="scores" runat="server" Text="confirm"/>
            <asp:Button id="cancel" OnClick="ret" runat="server" Text="cancel"/>
	</form>
</body>
</html>
