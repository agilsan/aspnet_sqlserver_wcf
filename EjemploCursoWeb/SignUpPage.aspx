<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUpPage.aspx.cs" Inherits="EjemploCursoWeb.SingUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>SignUp page</title>
    <link href="css/Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" class="frmalg">
        <div class="container">
            <center>
                <h3>Registro</h3>
            </center>
            <label for="uname"><b>Usuario</b></label>
            <asp:TextBox runat="server" ID="txt_Username" placeholder="Introduce el usuario"></asp:TextBox>
            <label for="psw"><b>Contraseña</b></label>
            <asp:TextBox runat="server" ID="txt_password" TextMode="Password" placeholder="Introduce la contraseña"></asp:TextBox>
            <label for="psw"><b>Repite contraseña</b></label>
            <asp:TextBox runat="server" ID="txt_password2" TextMode="Password" placeholder="Reintroduce la contraseña"></asp:TextBox>
            <asp:Button runat="server" ID="btn_SignUp" CssClass="lgnbtn" Text="Registrar" OnClick="btn_SignUp_Click"></asp:Button>
            <asp:Button runat="server" ID="btn_cancel" CssClass="cnbtn" Text="Cancelar" OnClick="btn_cancel_Click"></asp:Button>
        </div>
    </form>
</body>
</html>
