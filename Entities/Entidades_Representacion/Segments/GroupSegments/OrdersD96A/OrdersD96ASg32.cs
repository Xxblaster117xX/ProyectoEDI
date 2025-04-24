using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.OrdersD96A
{
    public class OrdersD96ASg32
    {
        public PciSegment PciSegment { get; set; } // Segmento de idenificación del paquete
        public RffSegment RffSegment { get; set; } // Segmento de referencia
        public DtmSegment DtmSegment { get; set; } // Segmento de fecha y hora
        public GinSegment GinSegment { get; set; } // Segmento de número de identificación del artículo
    }
}
