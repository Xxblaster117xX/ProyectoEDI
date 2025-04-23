using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.IftminD96A
{
    public class IftminD96Asg7
    {
        public TccSegment tccSegment { get; set; } // TCC - Código de tipo de carga
        public LocSegment locSegment { get; set; } // LOC - Localización
        public FtxSegment ftxSegment { get; set; } // FTX - Texto libre
        public CuxSegment cuxSegment { get; set; } // CUX - Divisa
        public PriSegment priSegment { get; set; } // PRI - Precio
        public EqnSegment eqnSegment { get; set; } // EQN - Cantidad
        public PcdSegment pcdSegment { get; set; } // PCD - Precio
        public MoaSegment moaSegment { get; set; } // MOA - Cantidad
        public QtySegment qtySegment { get; set; } // QTY - Cantidad
    }
}
