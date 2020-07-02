<%@ Page Language="C#" Inherits="Cesi.ProjetDominante.Client.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Login</title>
</head>
<body>
	<form id="form1" runat="server">
        <h1> CESI Decypher </h1>
            <h2> Login page</h2>
            <p> 
                Username:
                <asp:TextBox id = "UserName" runat="server"></asp:TextBox>
            </p>
            <p>
                Password:
                <asp:TextBox id = "Password" runat="server" TextMode="Password"></asp:TextBox>
            </p>    
            
            <asp:Button id="button1" runat="server" Text="Login" OnClick="button1Clicked" />
	</form>
</body>
</html>
