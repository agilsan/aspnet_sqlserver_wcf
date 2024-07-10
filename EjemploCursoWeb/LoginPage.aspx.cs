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
            WSHttpBinding basicHttp = new WSHttpBinding();
            basicHttp.Security.Mode = SecurityMode.None;
            basicHttp.Name = "MetadataExchangeHttpBinding_IService1";
            
            EndpointAddress endpoint = new EndpointAddress("http://localhost:56830/Service1.svc/mex");

            ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client(basicHttp, endpoint);

            var datos = obj.ObtenerUsuarios();
        }
    }
}