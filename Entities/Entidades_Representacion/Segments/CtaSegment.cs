using Entities.Entidades_Representacion;
using Entities.Entidades_Definicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments
{
    public class CtaSegment:SegmentDefinition
    {
        public string ContactFunctionCode { get; set; } // Código de función de contacto
        public string ContactInformation { get; set; } // Información de contacto

    }
}
