using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InventarioconLinQ_Lambda
{
    public partial class Inventario
    {
        public void ContarYAgruparProductos()
        {
            var grupos = productos.GroupBy(p => {
                if (p.Precio < 100) return "Menores a 100";
                else if (p.Precio <= 500) return "Entre 100 y 500";
                else return "Mayores a 500";
            });

            foreach (var grupo in grupos)
            {
                Console.WriteLine($"{grupo.Key}: {grupo.Count()} productos");
            }
        }

        public void AgregarProductoCondiciones(string nombre, decimal precio)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("El nombre del producto no puede estar vacío.");
                return;
            }

            if (Regex.IsMatch(nombre, @"\d"))
            {
                Console.WriteLine("El nombre del producto no puede contener numeros.");
                return;
            }

            if (precio <= 0)
            {
                Console.WriteLine("Precio invalido,Ingrese otro: ");
                return;
            }

            productos.Add(new Producto(nombre, precio));
        }

        public void GenerarReporteProductos()
        {
            Console.WriteLine($"Número total de productos: {productos.Count}");
            Console.WriteLine($"Precio promedio de todos los productos: {productos.Average(p => p.Precio)}");
            Console.WriteLine($"Producto con el precio más alto: {productos.OrderByDescending(p => p.Precio).First().Nombre}");
            Console.WriteLine($"Producto con el precio más bajo: {productos.OrderBy(p => p.Precio).First().Nombre}");
        }
    }
}
