using System;
using System.Reflection;

namespace SolidChallenge07
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto();
            a1.ID = 1;
            a1.NumeroChasis = 10302;
            a1.FechaFabricacion = new DateTime(2022,05,21);
            a1.Marca = "Volkswagen";
            a1.Modelo = "Gol Trend";
            a1.TipoCombustible = "Nafta";
            a1.CilindradaMotor = "1.6v";
            a1.Precio = 750372;
            PropertyInfo[] lista = typeof(Auto).GetProperties();
            foreach (PropertyInfo propinfo in lista)
            {
                string mostrarAtributo = propinfo.Name;
                string valor = propinfo.GetValue(a1).ToString();
                Console.WriteLine(mostrarAtributo+" :"+valor);
                
            }
            a1.SistemaDireccion();
            a1.SistemaTransmision();
            
        }
    }
}
