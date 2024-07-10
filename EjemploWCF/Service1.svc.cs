using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EjemploWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public void InsertarUsuario(string user, string pass)
        {
            contextoDatosDataContext contexto = new contextoDatosDataContext();

            Usuarios add_user = new Usuarios();

            add_user.NombreUsuario = user;
            add_user.Pass = pass;

            contexto.Usuarios.InsertOnSubmit(add_user);
            contexto.SubmitChanges();
        }

        public List<Usuarios> ObtenerUsuarios()
        {
            contextoDatosDataContext contexto = new contextoDatosDataContext();

            return (from r in contexto.Usuarios select r).ToList();
        }

        public bool VerificarAcceso(string user, string pass)
        {
            contextoDatosDataContext contexto = new contextoDatosDataContext();
            
            return (from r in contexto.Usuarios where r.NombreUsuario.Equals(user) && r.Pass.Equals(pass) select r).ToList().Count > 0;
        }
    }
}
