using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments
{
    public class NadSegment:Segment
    {
        // Indica el tipo de rol de la entidad puede ser BY, SU, DP, etc.
        public string partyQualifier { get; set; } 
        public string partyId { get; set; } // Identificación de la entidad
        public string partyIdCode { get; set; } // Código de identificación de la parte
        public string partyName { get; set; } // Nombre de la parte
        public string streetNumber { get; set; } // Calle y numero

    }
}
