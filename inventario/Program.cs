using System;
using System.Collections.Generic;

class Progra
{
    static void Main()
    {
        // Crea el diccionario de inventario
        Dictionary<string, int> inventario = new Dictionary<string, int>();

        while (true)
        {
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Actualizar cantidad");
            Console.WriteLine("4. Mostrar inventario");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Agregar producto
                    Console.Write("Nombre del producto: ");
                    string nombreProducto = Console.ReadLine();
                    Console.Write("Cantidad en stock: ");
                    int cantidad = int.Parse(Console.ReadLine());
                    inventario[nombreProducto] = cantidad;
                    break;

                case 2:
                    // Eliminar producto
                    Console.Write("Nombre del producto a eliminar: ");
                    string productoEliminar = Console.ReadLine();
                    inventario.Remove(productoEliminar);
                    break;

                case 3:
                    // Actualizar cantidad
                    Console.Write("Nombre del producto a actualizar: ");
                    string productoActualizar = Console.ReadLine();
                    Console.Write("Nueva cantidad en stock: ");
                    int nuevaCantidad = int.Parse(Console.ReadLine());
                    inventario[productoActualizar] = nuevaCantidad;
                    break;

                case 4:
                    // Mostrar inventario
                    Console.WriteLine("Inventario:");
                    foreach (var producto in inventario)
                    {
                        Console.WriteLine($"{producto.Key}: {producto.Value}");
                    }
                    break;

                case 5:
                    // Salir
                    Console.WriteLine("¡Hasta la proxima!");
                    return;

                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }
        }
    }
}