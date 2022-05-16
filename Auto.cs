using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SolidChallenge07
{
    class Auto : Vehiculo,ITransmision,IDireccion
    {
        public int NumeroChasis { get; set; }

        public string CilindradaMotor { get; set; }

        public ISeguroService _seguroService;

        public Auto(int id, string marca, string modelo, string tipocombustible, int precio, DateTime fechafabricacion,int numerochasis,string cilindradamotor,ISeguroService seguroService) :base(id,marca,modelo,tipocombustible,precio,fechafabricacion)
        {
            _seguroService = seguroService;
        }
        public Auto() : base()
        {
            
        }
        

        public void SistemaTransmision()
        {
            Console.WriteLine("Mi sistema de transmision es Automatica");
        }

        public void SistemaDireccion()
        {
            Console.WriteLine("Mi sistema de direccion es Electrica");
        }

        
        
            
        

        
    }
}
