using Entities.Entidades_Representacion.Segments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion.Segments.GroupSegments.AperakD96A;
namespace Entities.Entidades_Representacion.Documents
{
    public class AperakD96A
    {
        public UnhSegment UnhSegment { get; set; } // Segmento de encabezado del mensaje
        public BgmSegment BgmSegment { get; set; } // Segmento de inicio del mensaje
        public DtmSegment DtmSegment { get; set; } // Segmento de fecha y hora
        public FtxSegment FtxSegment { get; set; } // Segmento de texto libre
        public CntSegment CntSegment { get; set; } // Segmento de conteo
        public AperakD96ASg1 AperakD96ASg1 { get; set; } // Grupo de segmentos 1
        public AperakD96ASg2 AperakD96ASg2 { get; set; } // Grupo de segmentos 2
        public AperakD96ASg3 AperakD96ASg3 { get; set; } // Grupo de segmentos 3
        public AperakD96ASg4 AperakD96ASg4 { get; set; } // Grupo de segmentos 4

        public UntSegment UntSegment { get; set; } // Segmento de cierre del mensaje

    }
}
