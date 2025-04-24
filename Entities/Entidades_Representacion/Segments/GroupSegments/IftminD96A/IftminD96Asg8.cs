using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.IftminD96A
{
    public class IftminD96Asg8
    {
        public TdtSegment TdtSegment { get; set; } // Segmento de transporte
        public DtmSegment DtmSegment { get; set; } // Segmento de fecha y hora
        public TsrSegment TsrSegment { get; set; } // Segmento de información de transporte
        public IftminD96Asg9 IftminD96Asg9 { get; set; } // Segmento de información de transporte
        public IftminD96Asg10 IftminD96Asg10 { get; set; } // Segmento de información de transporte
    }
}
