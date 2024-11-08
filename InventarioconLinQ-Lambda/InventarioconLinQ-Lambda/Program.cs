using System;

namespace InventarioconLinQ_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
         
            Console.WriteLine("Bienvenido a nuestro sistema de gestion de Inventario.");

            Console.WriteLine("Cuantos productos desea agregar? ");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"\nProducto {i + 1}: ");
                Console.WriteLine($"Nombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Precio: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                Producto producto = new Producto(nombre, precio);
                inventario.AgregarProductoCondiciones(nombre, precio);
            }

            Console.WriteLine("\nIngrese el precio minimo para filtrar los productos: ");
            decimal precioMinimo = decimal.Parse(Console.ReadLine());

            var productosfiltrados = inventario.FiltrarYOrdenarProductos(precioMinimo);

            Console.WriteLine("\nProductos filtrados y ordenados: ");

            foreach(var producto in productosfiltrados)
            {
                Console.WriteLine(producto);
            }

            inventario.ContarYAgruparProductos();
            inventario.GenerarReporteProductos();
        }
    }
}