using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EstruturaWebApiDemo.Controllers
{
    public class HelloWorldController : ApiController
    {
        private readonly IEnumerable<TipoComplexo> _dados;

        public HelloWorldController()
        {
            _dados = new List<TipoComplexo> {
                new TipoComplexo {ID = 1, Nome = "Fabiano",Idade=36 },
                new TipoComplexo {ID = 2, Nome = "Priscila",Idade=37 },
                new TipoComplexo {ID = 3, Nome = "Raphael",Idade=16 },
            };
        }

        #region Informações Gerais
        /*
            Para ativar os verbos no IISExpress:
            Editar o arquivo C:\Users\fanalin\Documents\IISExpress\config\applicationhost.config
            Alterar a chave ExtensionlessUrl-Integrated-4.0

            GET: Está requisitando ao serviço um determinado recurso, apenas isso. Este verbo deve apenas extrair a informação, não alterando-a.
            POST: Indica ao serviço que a ele deve acatar o recurso que está sendo postado para o mesmo, e que muito vezes, o adicionamos em algum repositório.
            PUT: Indica que ao serviço que o recurso que está sendo colocado deve ser alterado se ele já existir, ou ainda, pode ser adicionado caso ele ainda não exista.
            DELETE: Indica que o serviço deve excluir o recurso.

            Para verificar os formatadores, acesse 
            GlobalConfiguration.Configuration.Formatters
            durante a excecução.

        */
        #endregion

        #region Métodos Get

        /*
            ** Raw do composer do Fiddler  **
            GET http://localhost:52605/api/HelloWorld HTTP/1.1
            User-Agent: Fiddler
            Host: localhost:52605
            Content-Type: application/json
        */

        public IEnumerable<TipoComplexo> Get()
        {
            return _dados;
        }

        /*

            ** raw do Composer do Fiddler **
            GET http://localhost:52605/api/HelloWorld/3 HTTP/1.1
            (ou ** GET http://localhost:52605/api/HelloWorld/Recuperar/?id=1 HTTP/1.1)
            Content-Type: application/xml

            public TipoComplexo Get(int id)
            {
                return dados.FirstOrDefault(d => d.ID == id);
            }

            ou

            [HttpGet]
            public TipoComplexo Recuperar(int id)
            {
                return dados.FirstOrDefault(d => d.ID == id);
            }

            ou

        */

        [ActionName("Recuperar")]
        public TipoComplexo Get(int id)
        {
            return _dados.FirstOrDefault(d => d.ID == id);
        }
        #endregion

        #region Métodos Post

        /*
        [NonAction]
        public void Post(TipoComplexo novoTipoComplexo)
        {
            //Método ignorado por causa do atributo
        }
        */

        /*
        ** raw do Composer do Fiddler - enviando json no RequestBody **
        POST http://localhost:52605/api/HelloWorld/Adicionar HTTP/1.1
        (ou ** POST http://localhost:52605/api/HelloWorld HTTP/1.1)
        Content-Type: application/json

        {"ID": 4,"Nome":"Testando via Fiddler","Idade":25}
        */

        /*
        ** raw do Composer do Fiddler - enviando um form no RequestBody **
        POST http://localhost:52605/api/HelloWorld HTTP/1.1
        Content-Type: application/x-www-form-urlencoded

        ID=12&Nome=Fabiano&Idade=36 
        */

        /*
        ** Postando via form no html **
        <form action="http://localhost:52605/api/HelloWorld" method="post">
            <input type="text" id="ID-Cli" name="ID" />
            <input type="text" id="Nome-Cli" name="Nome" />
            <input type="text" id="Idade-Cli" name="Idade" />
            <input type="submit" value="Enviar" />
        </form>
        */

        [HttpPost]
        public HttpResponseMessage Adicionar(TipoComplexo novoTipoAcomplexo)
        {
            return Request.CreateResponse(
                HttpStatusCode.Created,
                new { Msg = "Adicionado com sucesso", Value = novoTipoAcomplexo.ID });
        }

        /*
        [AcceptVerbs("POST", "PUT")]
        public void AdicionarOuAtualizar(TipoComplexo novoTipoAcomplexo)
        {
        }
        */

        /*
            Usado para tipos primitivos e que estão no RequestBody.
            Para tipos complexos não precisa

             ** raw do Composer do Fiddler - enviando no RequestBody um tipo primitivo**
             POST http://localhost:52605/api/HelloWorld HTTP/1.1
            Content-Type: application/json
            "teste"
        */
        /*
        public void Post([FromBody]string value)
        {
        }
        */

        #endregion

        #region Métodos PUT
        /*
            ** raw do Composer do Fiddler **
            PUT http://localhost:52605/api/HelloWorld/?id=1&nome=Teste+Silva HTTP/1.1
            Content-Type: application/json
        */
        public void Put(int ID, string Nome)
        {

        }
        #endregion

        #region Delete
        /*
            ** raw do Composer do Fiddler **
            DELETE http://localhost:52605/api/HelloWorld/1 HTTP/1.1
            Content-Type: application/json
        */
        public void Delete(int id)
        {

        }
        #endregion


    }

    public class TipoComplexo
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
