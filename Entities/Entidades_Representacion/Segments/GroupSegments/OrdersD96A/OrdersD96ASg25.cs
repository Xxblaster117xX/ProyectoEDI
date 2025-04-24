using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.OrdersD96A
{
    public class OrdersD96ASg25
    {
        public LinSegment LinSegment { get; set; } // Segmento de línea
        public PiaSegment PiaSegment { get; set; } // Segmento para especificar códigos de artículos adicionales o sustitutivos.
        public ImdSegment ImdSegment { get; set; } // Segmento para describir un artículo en formato industrial o libre.
        public MeaSegment MeaSegment { get; set; } // Segmento que especifica las medidas de un paquete
        public QtySegment QtySegment { get; set; } // Segmento para especificar cantidades
        public PcdSegment PcdSegment { get; set; }
        public AliSegment AliSegment { get; set; } // Segmento de información adicional
        public DtmSegment DtmSegment { get; set; } // Segmento de fecha y hora
        public MoaSegment MoaSegment { get; set; } // Segmento de cantidad monetaria
        public GinSegment GinSegment { get; set; }
        public GirSegment GirSegment { get; set; } // Para especificar un conjunto relacionado de números de identificación.
        public QvrSegment QvrSegment { get; set; } // Segmento para especificar la cantidad de un artículo en una unidad de medida diferente.
        public DocSegment DocSegment { get; set; } // Segmento para especificar un documento o mensaje relacionado con el artículo.
        public PaiSegment PaiSegment { get; set; } // Segmento que especifica las instrucciones del pago
        public FtxSegment FtxSegment { get; set; } // Segmento de texto libre
        public OrdersD96ASg26 OrdersD96ASg26 { get; set; }
        public OrdersD96ASg27 OrdersD96ASg27 { get; set; }
        public OrdersD96ASg28 OrdersD96ASg28 { get; set; }
        public OrdersD96ASg29 OrdersD96ASg29 { get; set; }
        public OrdersD96ASg30 OrdersD96ASg30 { get; set; }
    }
}
