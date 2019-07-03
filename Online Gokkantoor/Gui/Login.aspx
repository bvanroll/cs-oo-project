<%@ Page Language="C#" Inherits="Gui.Login" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Login</title>
</head>
<body>
    <h1>HI</h1>
	<form id="form1" runat="server">
            <asp:ListBox id="lstUsers" runat="server"/>
            <asp:Button id="LoginBtn" runat="server" OnClick="Login_Click"/>
	</form>
</body>
</html>
