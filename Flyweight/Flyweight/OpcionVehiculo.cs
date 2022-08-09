using System;
namespace Flyweight
{
    public class OpcionVehiculo
    {
        protected string nombre;
        protected string descripcion;
        protected int precioEstandar;

        public OpcionVehiculo(string nombre)
        {
            this.nombre = nombre;
            this.descripcion = "Descripcion de " + nombre;
            this.precioEstandar = 100;
        }

        public void Visualiza(int precioDeVenta) {
            Console.WriteLine("Opcion");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine(descripcion);
            Console.WriteLine("Precio estándar: " + precioEstandar);
            Console.WriteLine("Precio de venta: " + precioDeVenta);
        }
    }
}

