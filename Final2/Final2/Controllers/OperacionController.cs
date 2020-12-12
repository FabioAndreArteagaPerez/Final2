using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Final2.Controllers
{
    public class OperacionController : ApiController
    {
        public string Get(int id)
        {
            if(id<0)
            {
                return "ERROR";
            }
            if(id==0)
            {
                return "Realizado por Fabio";
            }
            return "https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg";
        }
    }
}
