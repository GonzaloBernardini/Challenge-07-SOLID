using System;
using System.Collections.Generic;
using System.Text;

namespace SolidChallenge07
{
    abstract class Vehiculo
    {
        protected int id { get; set; }
        protected string marca { get; set; }
        protected string modelo { get; set; }
        protected string tipoCombustible { get; set; }
        protected int precio { get; set; }
        protected DateTime fechafabricacion { get ; set; }

        


        public int ID { get => id; set=> id =value; }
        public string Marca { get =>marca; set => marca=value; }
        public string Modelo { get =>modelo; set=> modelo=value; }
        public string TipoCombustible { get=>tipoCombustible; set=> tipoCombustible=value; }
        public int Precio { get=>precio; set=> precio=value; }
        public DateTime FechaFabricacion { get=> fechafabricacion; set=>fechafabricacion=value; }


        //Abstraccion de clase y que se encargue solo del modelo.Unico objetivo.
        //Esta clase se puede extender pero jamas podra ser otro tipo de entidad como producto persona etc.

        public Vehiculo(int id ,string marca,string modelo,string tipocombustible,int precio,DateTime fechafabricacion)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.tipoCombustible = tipocombustible;
            this.precio = precio;
            this.fechafabricacion = fechafabricacion;
            
        }
        public Vehiculo()
        {
            
        }
        
    }
}
