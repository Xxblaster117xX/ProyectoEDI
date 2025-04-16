using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
namespace Entities.Entidades_Representacion.Segments
{
    public class ComSegment:Segment
    {
        public string communicationContact { get; set; } // tipo de comounicación
        public string communicationNumber { get; set; } // número o direccion del tipo de comunicación
        public string communicationQualifier { get; set; } // Calificador de comunicación
    }
}
