﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDemoRazorPages.Model
{
    public class Producto
    {
        public  int Id { get; set; }

        public string Nombre { get; set; }

        public string Marca { get; set; }
        public decimal Precio { get; set; }
    }
}
