﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustriasTecGaem.BL
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        //agregados de categoria
       // public int CategoriaId { get; set; }
        public Categorias categoria { get; set; }
        public bool Activo { get; set; }
    }
}
