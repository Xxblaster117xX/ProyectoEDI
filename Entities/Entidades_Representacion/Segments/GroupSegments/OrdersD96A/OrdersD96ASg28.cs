using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.OrdersD96A
{
    public class OrdersD96ASg28
    {
        public PriSegment PriSegment { get; set; } // Segmento de información de precio
        public CuxSegment CuxSegment { get; set; } // Segmento de información de divisa
        public AprSegment AprSegment { get; set; } // Segmento de información adicional de precio
        public RngSegment RngSegment { get; set; } // Segmento de rango
        public DtmSegment DtmSegment { get; set; } // Segmento de fecha y hora

    }
}
