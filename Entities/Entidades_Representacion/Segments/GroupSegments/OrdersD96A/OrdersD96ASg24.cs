using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.OrdersD96A
{
    public class OrdersD96ASg24
    {
        public RcsSegment RcsSegment { get; set; } 
        public RffSegment RffSegment { get; set; } // Segmento de referencia
        public DtmSegment DtmSegment { get; set; } // Segmento de fecha y hora
        public FtxSegment FtxSegment { get; set; } // Segmento de texto libre
        public OrdersD96ASg25 OrdersD96ASg25 { get; set; } 
    }
}
