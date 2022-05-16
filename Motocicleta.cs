using System;
using System.Collections.Generic;
using System.Text;

namespace SolidChallenge07
{
    class Motocicleta : Vehiculo,ITransmision,IDireccion
    {
        public Motocicleta(int id, string marca, string modelo, string tipocombustible, int precio, DateTime fechafabricacion, int numerochasis, string cilindradamotor) :base(id, marca, modelo, tipocombustible, precio, fechafabricacion)
        {

        }
        public Motocicleta():base()
        {

        }

        

        public void SistemaTransmision()
        {
            Console.WriteLine("Mi sistema de transmision es por cadena");
        }

        public void SistemaDireccion()
        {
            Console.WriteLine("Mi sistema de Direccion es Hidraulico");
        }
    }
}
