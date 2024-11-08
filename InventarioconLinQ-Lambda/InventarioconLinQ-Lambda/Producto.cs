﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioconLinQ_Lambda
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Producto:{Nombre}, Precio: {Precio:C}");
        }
    }
}
