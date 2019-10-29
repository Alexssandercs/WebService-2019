using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFun.Entity
{
    public class Compra
    {
        public int id { get; set; }
        public float valorCompra { get; set; }
        public List<Item> carrinho { get; set; }
    }
}