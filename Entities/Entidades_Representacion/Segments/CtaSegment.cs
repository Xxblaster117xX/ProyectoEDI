using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments
{
    public class CtaSegment:Segment
    {
        public string contactFunctionCode { get; set; } // Código de función de contacto
        public string contactInfpormation { get; set; } // Información de contacto

    }
}
