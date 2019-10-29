using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Xml.XmlConfiguration;
using System.Data;
using System.Xml.Serialization;

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
        private string idt_func = "0";
        private string nome_func="teste1";
        private string descricao_func="teste2";
        private string categoria_func="1";
        private string modelo_func="teste@gmail.com";
        private string marca_func= "teste";
        private string valor_func= "2";
        private string quantidade_func="3";


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Xml)]
        public xml ObterProdutoPorMarca(string marca_produto)
        {
            //Criando lista de produtos
            List<Produto> produtos = new List<Produto>();



            Produto produto;
            //Obtendo todos os produtos
            DataTable dteProd = DadosProduto();
            //Populando a lista de produtos
            foreach (DataRow row in dteProd.Rows)
            {
                produto = new Produto();
                produto.idt_func = row[idt_func].ToString();
                produto.nome_func = row[nome_func].ToString();
                produto.descricao_func = row[descricao_func].ToString();
                produto.categoria_func = row[categoria_func].ToString();
                produto.modelo_func = row[modelo_func].ToString();
                produto.marca_func = row[marca_func].ToString();
                produto.valor_func = row[valor_func].ToString();
                produto.quantidade_func = row[quantidade_func].ToString();
                produtos.Add(produto);
            }

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

        //Estrutura do XML de produtos
        public class Produto
        {
            [XmlElement("idt_func")]
            public string idt_func { get; set; }

            [XmlElement("nome")]
            public string nome_func { get; set; }

            [XmlElement("descricao")]
            public string descricao_func { get; set; }

            [XmlElement("categoria")]
            public string categoria_func { get; set; }

            [XmlElement("modelo")]
            public string modelo_func { get; set; }

            [XmlElement("marca")]
            public string marca_func { get; set; }

            [XmlElement("valor")]
            public string valor_func { get; set; }

            [XmlElement("quantidade")]
            public string quantidade_func { get; set; }

        }

        //Classe que recebe a lista de produto e retorna o XML

        [XmlRoot("xml")]
        public class xml
        {
            public xml() { }
            public xml(List<Produto> produto)
            {
                this.produto = produto;
            }
            public List<Produto> produto { get; set; }
        }

        //Criando dados fictícios de produtos
        public DataTable DadosProduto()
        {
            DataTable dadosProdutos = new DataTable();
            dadosProdutos.Columns.Add(idt_func);
            dadosProdutos.Columns.Add(nome_func);
            dadosProdutos.Columns.Add(descricao_func);
            dadosProdutos.Columns.Add(categoria_func);
            dadosProdutos.Columns.Add(modelo_func);
            dadosProdutos.Columns.Add(marca_func);
            dadosProdutos.Columns.Add(valor_func);
            dadosProdutos.Columns.Add(quantidade_func);
            //                     ID    Nome                     Descrição                                                                                  Categoria      Modelo                     Marca              Valor     QT                   
            dadosProdutos.Rows.Add("1", "Galaxy A20",             "Smartphone 32 GB - Preto",                                                                "Celular",     "SM - A205G",              "Samsumg",         "739",    "4");
            dadosProdutos.Rows.Add("2", "Memória HyperX Fury",    "8GB 2666MHz, DDR4 - Preto",                                                               "Memoria Ram", "HX426C16FB3 / 8",         "HyperX",          "232,82", "10");
            dadosProdutos.Rows.Add("3", "SSD Kingston A400",      "SSD Kingston A400, 240GB, SATA, Leitura 500MB / s, Gravação 350MB / s - SA400S37 / 240G", "SSD",         "SA400S37 / 240G",         "Kingston",        "205,76", "6");
            dadosProdutos.Rows.Add("4", "Asus Prime Gaming - BR", "As placas - mãe ASUS Prime Série B450",                                                   "Placa - Mãe", "Prime B450M Gaming / BR", "ASUS",            "455,9",  "2");
            dadosProdutos.Rows.Add("5", "Acer Aspire Nitro 5",    "Intel Core i5 - 7300HQ 8GB 1TB NVIDIA GeForce GTX 1050 4GB GDDR5 15, 6",                  "Notbook",     "AN515 - 51 - 55YB",       "ACER",            "3699,9", "1");
            dadosProdutos.Rows.Add("6", "Acer Aspire Nitro 3",    "AMD Ryzen 3 2200U, 4GB, 1TB, Radeon Vega 3, Windows 10 Home, 15.6",                       "Notbook",     "A315 - 41 - R790",        "ACER",            "2199,9", "2");
            dadosProdutos.Rows.Add("7", "Sharkoon",               "HUB Sharkoon USB 3.0 4 Portas Tipo - C Alumínio BK",                                      "Periferico",  "HUB",                     "Sharkoon",        "119,88", "4");
            dadosProdutos.Rows.Add("8", "DataTraveler",           "Pen Drive Kingston DataTraveler USB 3.0 32GB",                                            "Periferico",  "DT100G3",                 "Kingston",        "38,71",  "20");
            dadosProdutos.Rows.Add("9", "Calculadora Vinik",      "Calculadora Científica Vinik 10 + 2 Dígitos 240 Funções CC20 - 26096 Preta",              "Eletronico",  "26096",                   "Vinik",           "18,71",  "30");
            dadosProdutos.Rows.Add("10", "SSD WD",                "SSD WD Green, 240GB, SATA, Leitura 545MB / s, Gravação 465MB / s",                        "SSD",         "WDS240G2G0A",             "Western Digital", "246,94", "7");



            return dadosProdutos;
        }

    }
}
