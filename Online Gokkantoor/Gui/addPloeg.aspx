<%@ Page Language="C#" Inherits="Gui.addPloeg" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>addPloeg</title>
</head>
<body>
	<form id="form1" runat="server">
            <p>naam</p>
            <asp:TextBox id="naam" runat="server"/>
            <asp:Label id="status" runat="server" />
            <asp:Button id="confirm" runat="server" Text="confirm" OnClick="confirm_Click"/>
            <asp:Button id="ret" runat="server" Text="Return" OnClick="ret_Click"/>
	</form>
</body>
</html>
