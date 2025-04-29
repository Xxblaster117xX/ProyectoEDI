using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion;
using Entities.Entidades_Representacion.Abstract;
namespace Entities.Entidades_Representacion.Segments
{
    public class ComSegment:SegmentRepresentation
    {
        public string CommunicationContact { get; set; } // tipo de comounicación
        public string CommunicationNumber { get; set; } // número o direccion del tipo de comunicación
        public string CommunicationQualifier { get; set; } // Calificador de comunicación
    }
}
