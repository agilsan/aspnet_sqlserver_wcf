using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace EjemploCursoWeb
{
    public class Connection
    {
        public ServiceReference1.Service1Client NewConnection()
        {
            WSHttpBinding basicHttp = new WSHttpBinding();
            basicHttp.Security.Mode = SecurityMode.None;
            basicHttp.Name = "MetadataExchangeHttpBinding_IService1";

            EndpointAddress endpoint = new EndpointAddress("http://localhost:56830/Service1.svc/mex");

            return new ServiceReference1.Service1Client(basicHttp, endpoint);
        }
    }
}