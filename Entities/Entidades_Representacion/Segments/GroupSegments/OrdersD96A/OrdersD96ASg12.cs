using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.OrdersD96A
{
    public class OrdersD96ASg12
    {
        public PacSegment PacSegment { get; set; } // Segmento de información del paquete
        public MeaSegment MeaSegment { get; set; } // Segmento que especifica las medidas de un paquete
        public OrdersD96ASg13 OrdersD96ASg13 { get; set; }
    }
}
