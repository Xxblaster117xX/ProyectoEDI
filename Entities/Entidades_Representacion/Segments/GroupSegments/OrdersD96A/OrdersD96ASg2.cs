using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.OrdersD96A
{
    public class OrdersD96ASg2
    {
        public NadSegment NadSegment { get; set; } // Segmento de nombre y dirección
        public LocSegment LocaSegment { get; set; } // Segmento de localización
        public FiiSegment FiiSegment { get; set; } // Segmento de información financiera
        public OrdersD96ASg3 OrdersD96ASg3 { get; set; } 
        public OrdersD96ASg4 OrdersD96ASg4 { get; set; }
        public OrdersD96ASg5 OrdersD96ASg5 { get; set; }



    }
}
