using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.OrdersD96A
{
    public class OrdersD96ASg14
    {
        public EqdSegment EqdSegment { get; set; } // Segmento de equipo
        public HanSegment HanSegment { get; set; } // Segmento de manejo
        public MeaSegment MeaSegment { get; set; } // Segmento que especifica las medidas de un paquete
        public FtxSegment FtxSegment { get; set; } // Segmento de texto libre
    }
}
