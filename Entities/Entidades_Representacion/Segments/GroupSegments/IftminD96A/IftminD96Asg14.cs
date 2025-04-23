using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.IftminD96A
{
    public class IftminD96Asg14
    {
        public TccSegment tccSegment { get; set; } // TCC - Tipo de carga
        public PriSegment priSegment { get; set; } // PRI - Información de precio
        public EqnSegment eqnSegment { get; set; } // EQN - Número de equipo
        public PcdSegment pcdSegment { get; set; } // PCD - Información de carga
        public MoaSegment moaSegment { get; set; } // MOA - Monto
        public QtySegment qtySegment { get; set; } // QTY - Cantidad
    }
}
