<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Formulario de Login</title>
    <link rel="stylesheet" href="Css-Estilos/estilos.css" />

</head>
<body>
	
				 <!-----start-main---->
				<div class="login-form">
						<h1>ACCESO AL SISTEMA</h1>
						
				        <form id="form1" runat="server">
					<li>
                        <asp:TextBox ID="txtUsuario" value="User Name" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'User Name';}" runat="server" ></asp:TextBox><a href="#" class=" icon Log"></a>
                        &nbsp;
                    </li>
					<li>
                        <asp:TextBox type="password" ID="txtClave" value="Password" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Password';}" runat="server" ></asp:TextBox><a href="#" class=" icon lock"></a>
						
					</li>
					
					 <div class ="forgot">
						 <asp:Button ID="Button1" runat="server" Text="Login" />
                         <a href="#" class=" icon arrow"></a>                                                                                                                                                                                                                                 &nbsp;</h4>
					</div>
				        </form>
			</div>			
		   
		 		
</body>

</html>
