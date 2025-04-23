using Entities.Abstract;
using Entities.Entidades_Definicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments
{
    public class RffSegment:Segment
    {
        public string referenceQualifier { get; set; } // indica el tipo de referencia
        public int referenceNumber { get; set; } // Número de referencia
        public int referenceVersion { get; set; } // Número de versión
    }
}
