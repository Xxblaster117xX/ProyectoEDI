

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion.Abstract;

namespace Entities.Entidades_Representacion.Segments
{
    public class UnhSegment:SegmentRepresentation
    {
        // identificador único para el mensaje dentro del intercambio.
        public int ReferenceNumber { get; set; } 
        public string ControllingAgency { get; set; } // Agencia de control del mensaje

        /*se le puede añadir otros atributos como el tipo de mensaje, tipo de versión
         * y el release del mensaje pero están como atrb en la clase mensaje.
         
         */


    }
}
