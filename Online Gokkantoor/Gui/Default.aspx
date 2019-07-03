<%@ Page Language="C#" Inherits="Gui.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
    <p>lorem ipsum</p>
	<form id="form1" runat="server">
		<asp:Button id="button1" runat="server" Text="Login" OnClick="button1Clicked" />
            <asp:Button id="adminBtn" runat="server" Text="admin" OnClick="buttonAdminClicked" />
	</form>
</body>
</html>
