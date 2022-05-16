using System;
using System.Collections.Generic;
using System.Text;

namespace SolidChallenge07
{
    class GenerarSeguroService
    {
        public readonly ISeguroService _seguroService;
        //public readonly LaNuevaSeguros _laNuevaSeguros;
        //Esta clase dependendia fuertemente de la clase la nueva seguros.
        public GenerarSeguroService(/*LaNuevaSeguros seguro*/ISeguroService SeguroService)
        {
            //_laNuevaSeguros = seguro;
            _seguroService = SeguroService;
        }

        //Metodo generico para recibir cualquier tipo de vehiculo y asignarle un seguro segun requerimientos
        public void GenerarSeguro<T>(T s)
        {
            _seguroService.SeguroInfo(" El tipo de seguro es : ...");
        }
    }
}
