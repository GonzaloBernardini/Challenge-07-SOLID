using System;
using System.Collections.Generic;
using System.Text;

namespace SolidChallenge07
{
    class Camion : Vehiculo,ITransmision,IDireccion
    {

        public Camion(int id, string marca, string modelo, string tipocombustible, int precio, DateTime fechafabricacion):base(id, marca, modelo, tipocombustible, precio, fechafabricacion)
        {

        }
        public Camion():base()
        {

        }

        

        public void SistemaTransmision()
        {
            Console.WriteLine("Mi sistema de transmision es secuencial");
        }

        public void SistemaDireccion()
        {
            Console.WriteLine("Mi sistema de direccion es Asistida");
        }
    }
}
