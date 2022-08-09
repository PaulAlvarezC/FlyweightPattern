using System;
namespace Flyweight
{
    public class Cliente
    {
        public static void Main(string[] args) {
            FabricaOpcion fabrica = new FabricaOpcion();
            VehiculoSolicitado vehiculo = new VehiculoSolicitado();

            vehiculo.agregaOpciones("Air bag", 80, fabrica);
            vehiculo.agregaOpciones("dirección asistida", 90, fabrica);
            vehiculo.agregaOpciones("Elevalunas eléctricos", 85, fabrica);
            vehiculo.muestraOpciones();
        }
    }
}

