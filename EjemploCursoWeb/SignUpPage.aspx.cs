using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemploCursoWeb
{
    public partial class SingUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("LoginPage.aspx");
        }

        protected void btn_SignUp_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client servicio = new Connection().NewConnection();

            if ("".Equals(txt_Username.Text.Trim()))
            {
                Response.Write("<script>alert('El usuario no puede ser vacío.');</script>");
                return;
            }

            if ("".Equals(txt_password.Text.Trim()) && txt_password.Text == txt_password2.Text)
            {
                Response.Write("<script>alert('La contraseña no puede ser vacía.');</script>");
                return;
            }
            else if (txt_password.Text != txt_password2.Text)
            {
                Response.Write("<script>alert('La contraseña ha de ser igual.');</script>");
                return;
            }

            if (servicio.VerificarUsuario(txt_Username.Text))
            {
                Response.Write("<script>alert('El usuario ya existe.');</script>");
            }
            else
            {
                servicio.InsertarUsuario(txt_Username.Text, txt_password.Text);
                HttpContext.Current.Response.Redirect("DatosPage.aspx");
            }
        }
    }
}