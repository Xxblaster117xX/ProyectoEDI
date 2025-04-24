
using Entities.Entidades_Representacion.Abstract;
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
        public string PartyQualifier { get; set; } 
        public string PartyId { get; set; } // Identificación de la entidad
        public string PartyIdCode { get; set; } // Código de identificación de la parte
        public string PartyName { get; set; } // Nombre de la parte
        public string StreetNumber { get; set; } // Calle y numero

    }
}
