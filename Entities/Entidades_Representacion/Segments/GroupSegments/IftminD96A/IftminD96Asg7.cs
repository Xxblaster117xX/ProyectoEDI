using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.IftminD96A
{
    public class IftminD96Asg7
    {
        public TccSegment TccSegment { get; set; } // TCC - Código de tipo de carga
        public LocSegment LocSegment { get; set; } // LOC - Localización
        public FtxSegment FtxSegment { get; set; } // FTX - Texto libre
        public CuxSegment CuxSegment { get; set; } // CUX - Divisa
        public PriSegment PriSegment { get; set; } // PRI - Precio
        public EqnSegment EqnSegment { get; set; } // EQN - Cantidad
        public PcdSegment PcdSegment { get; set; } // PCD - Precio
        public MoaSegment MoaSegment { get; set; } // MOA - Cantidad
        public QtySegment QtySegment { get; set; } // QTY - Cantidad
    }
}
