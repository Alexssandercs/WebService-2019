using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebFun.Entity
{
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
}