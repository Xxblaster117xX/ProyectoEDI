using Entities.Entidades_Representacion.Segments;
using Entities.Entidades_Representacion.Segments.GroupSegments.OrdersD96A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Documents
{
    public class OrdersD96A
    {
        public UnhSegment UnhSegment { get; set; } // Segmento de encabezado del mensaje
        public BgmSegment BgmSegment { get; set; } // Segmento de inicio del mensaje
        public PaiSegment PaiSegment { get; set; } // Segmento de información del pagador
        public AliSegment AliSegment { get; set; } // Segmento de información adicional
        public ImdSegment ImdSegment { get; set; } // Segmento de información del artículo
        public FtxSegment FtxSegment { get; set; } // Segmento de texto libre
        public OrdersD96ASg1 OrdersD96ASg1 { get; set; }
        public OrdersD96ASg2 OrdersD96ASg2 { get; set; }
        public OrdersD96ASg6 OrdersD96ASg6 { get; set; }
        public OrdersD96ASg7 OrdersD96ASg7 { get; set; }
        public OrdersD96ASg8 OrdersD96ASg8 { get; set; }
        public OrdersD96ASg9 OrdersD96ASg9 { get; set; }
        public OrdersD96ASg11 OrdersD96ASg11 { get; set; }
        public OrdersD96ASg12 OrdersD96ASg12 { get; set; }
        public OrdersD96ASg14 OrdersD96ASg14 { get; set; }
        public OrdersD96ASg15 OrdersD96ASg15 { get; set; }
        public OrdersD96ASg17 OrdersD96ASg17 { get; set; }
        public OrdersD96ASg18 OrdersD96ASg18 { get; set; }
        public OrdersD96ASg24 OrdersD96ASg24 { get; set; }
        public OrdersD96ASg25 OrdersD96ASg25 { get; set; }
        public UnsSegment UnsSegment { get; set; }
        public MoaSegment MoaSegment { get; set; } // Segmento de cantidad monetaria
        public CntSegment CntSegment { get; set; } // Segmento de conteo
        public OrdersD96ASg54 OrdersD96ASg54 { get; set; }
        public UntSegment UntSegment { get; set; } // Segmento de cierre del mensaje
    }
}
