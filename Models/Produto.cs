﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Produto
    {
        public int  Id{ get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string BarCode { get; set; }
        public decimal Preco { get; set; }
        public Categoria FK { get; set; } 
    }
}
