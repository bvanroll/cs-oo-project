<%@ Page Language="C#" Inherits="Gui.addBalance" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>addBalance</title>
</head>
<body>
	<form id="form1" runat="server">
            
        <asp:TextBox id="balans" runat="server"/>
            <asp:Label id="statusLabel" runat="server"/>
            <asp:Button id="confirm" OnClick="add" runat="server"/>
	</form>
</body>
</html>
