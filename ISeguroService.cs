using System;
using System.Collections.Generic;
using System.Text;

namespace SolidChallenge07
{
    interface ISeguroService
    {
        //Con esta interfaz ahora mis clases pueden implementarla y establecer un tipo de seguro , segun las especificaciones.
        //No necesito que mis clases dependan de una clase especifica "seguro  N" sino que ahora pueden implementar esta interfaz.
        //y Cumplimos nuestro objetivo de Inversion de Dependencias
        void SeguroInfo(string mensaje);
    }
}
