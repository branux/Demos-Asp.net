using System.Web.Mvc;

namespace DemoHelloWorldIdentity.Controllers
{
    [Authorize]
    public class SecretoController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return Content("Aberto pra qualquer usuário");
        }

        public ActionResult Secreto()
        {
            return Content("Para usuários autenticados");
        }

        [Authorize(Users="fabiano.nalin@gmail.com")]
        public ActionResult UsuarioEspecifico()
        {
            return Content("Para usuário fabiano.nalin@gmail.com");
        }
    }
}