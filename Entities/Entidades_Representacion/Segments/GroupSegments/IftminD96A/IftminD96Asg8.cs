using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.IftminD96A
{
    public class IftminD96Asg8
    {
        public TdtSegment tdtSegment { get; set; } // Segmento de transporte
        public DtmSegment dtmSegment { get; set; } // Segmento de fecha y hora
        public TsrSegment tsrSegment { get; set; } // Segmento de información de transporte
        public IftminD96Asg9 iftminD96Asg9 { get; set; } // Segmento de información de transporte
        public IftminD96Asg10 iftminD96Asg10 { get; set; } // Segmento de información de transporte
    }
}
