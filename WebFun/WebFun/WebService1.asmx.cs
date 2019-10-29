using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Xml.XmlConfiguration;
using System.Data;
using System.Xml.Serialization;
using WebFun.Entity;

namespace WebFun
{
    /// <summary>
    /// Descrição resumida de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        private List<Produto> estoque;
        private List<Compra> compras;


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Xml)]
        public xml ObterProdutoPorMarca(string marca_produto)
        {
            List<Produto> produtos = DAL.Produto.Instance.ListarProdutos();

            //Filtrando apenas produtos da marca escolhida
            var result = from f in produtos select f;
            if (marca_produto != "todas")
            {
                result = from f in produtos
                where f.marca_func.Equals(marca_produto)
                select f;
            }

            

            //Popular a Classe xml
            xml dadosXML = new xml(result.ToList());
            //Retornar o xml

            return dadosXML;
        }

      

 

       

    }
}
