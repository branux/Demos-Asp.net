using System.Web.Http;

namespace OwinComWebApi
{
    public class MensagemController : ApiController
    {
        public Mensagem Get()
        {
            return new Mensagem { Texto = "Hello World!" };
        }
    }
}
