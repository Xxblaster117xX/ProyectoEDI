using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.OrdersD96A
{
    public class OrdersD96ASg39
    {
        public AlcSegment AlcSegment { get; set; } // Para identificar los detalles de los derechos o cargos
        public AliSegment AliSegment { get; set; } // Para identificar la información adicional relacionada con el artículo
        public DtmSegment DtmSegment { get; set; } // Para especificar la fecha y hora de un evento o acción

        public OrdersD96ASg40 OrdersD96ASg40 { get; set; } 
        public OrdersD96ASg41 OrdersD96ASg41 { get; set; }
        public OrdersD96ASg42 OrdersD96ASg42 { get; set; }
        public OrdersD96ASg43 OrdersD96ASg43 { get; set; }
        public OrdersD96ASg44 OrdersD96ASg44 { get; set; }

    }
}
