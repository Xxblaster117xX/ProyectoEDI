using Entities.Abstract;
using Entities.Entidades_Representacion.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments
{
    public class UnhSegment:Segment
    {
        // identificador único para el mensaje dentro del intercambio.
        public int ReferenceNumber { get; set; } 
        public string controllingAgency { get; set; } // Agencia de control del mensaje

        /*se le puede añadir otros atributos como el tipo de mensaje, tipo de versión
         * y el release del mensaje pero están como atrb en la clase mensaje.
         
         */


    }
}
