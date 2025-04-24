using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.OrdersD96A
{
    public class OrdersD96ASg30
    {
        public PacSegment PacSegment { get; set; } // Segmento de información de paquete
        public MeaSegment MeaSegment { get; set; } // Segmento de información de medida
        public QtySegment QtySegment { get; set; } // Segmento de cantidad
        public DtmSegment DtmSegment { get; set; } // Segmento de fecha y hora  

        public OrdersD96ASg31 OrdersD96ASg31 { get; set; } 
        public OrdersD96ASg32 OrdersD96ASg32 { get; set; }
    }
}
