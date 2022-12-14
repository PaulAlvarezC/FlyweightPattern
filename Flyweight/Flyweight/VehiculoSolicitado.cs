using System.Collections.Generic;
namespace Flyweight
{
    public class VehiculoSolicitado
    {
        protected IList<OpcionVehiculo> opciones = new List<OpcionVehiculo>();
        protected IList<int> precioDeVentaOpciones = new List<int>();

        public void agregaOpciones(string nombre, int precioDeVenta, FabricaOpcion fabrica) {
            opciones.Add(fabrica.getOpcion(nombre));
            precioDeVentaOpciones.Add(precioDeVenta);
        }

        public void muestraOpciones() {
            int indice, tamanio;
            tamanio = opciones.Count;

            for (indice = 0; indice < tamanio; indice++) {
                opciones[indice].Visualiza(precioDeVentaOpciones[indice]);
                Console.WriteLine();
            }
        }
    }
}

