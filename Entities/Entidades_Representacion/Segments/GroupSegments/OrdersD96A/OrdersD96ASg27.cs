using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.OrdersD96A
{
    public class OrdersD96ASg27
    {
        public PatSegment PatSegment { get; set; } // Segmento para los terminos y las bases del pago
        public DtmSegment DtmSegment { get; set; } // Segmento de fecha y hora
        public PcdSegment PcdSegment { get; set; } // Segmento para especificar información porcentual
        public MoaSegment MoaSegment { get; set; } // Segmento que indica la cantidad monetaria

    }
}
