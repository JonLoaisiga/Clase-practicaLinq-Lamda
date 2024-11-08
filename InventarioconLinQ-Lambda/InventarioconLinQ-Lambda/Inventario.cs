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
        private List<Producto> productos;

        public Inventario()
        {
            productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
           productos.Add(producto);
        }
    
        public IEnumerable<Producto> FiltrarYOrdenarProductos(decimal precioMinimo)
        {
             return productos
            .Where(p => p.Precio > precioMinimo).OrderBy(p => p.Precio);
        }

        public void CambiarPrecio(string nombre, decimal nuevoPrecio)
        {
            var producto = productos.FirstOrDefault(p => p.Nombre == nombre); 

           if (producto != null)
           {
                producto.Precio = nuevoPrecio;
           }
        }

        public void EliminarunProducto(string nombre)
        {
            var producto = productos.FirstOrDefault(p => p.Nombre == nombre);

            if (producto != null)
            {
                productos.Remove(producto);
            }
        }
    }
}
