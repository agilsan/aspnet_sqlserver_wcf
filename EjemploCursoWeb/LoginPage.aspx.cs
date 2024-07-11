using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemploCursoWeb
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client servicio = new Connection().NewConnection();

            if (servicio.VerificarAcceso(txt_Username.Text, txt_password.Text))
            {
                HttpContext.Current.Response.Redirect("DatosPage.aspx");
            } else
            {
                Response.Write("<script>alert('Usuario incorrecto.');</script>");
            }
        }

        protected void link_signup_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("SignUpPage.aspx");
        }
    }
}