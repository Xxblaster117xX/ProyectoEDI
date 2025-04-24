using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.IftminD96A
{
    public class IftminD96Asg38
    {
        public TccSegment TccSegment { get; set; } // TCC - Código de tipo de carga
        public PriSegment PriSegment { get; set; } // PRI - Información de precio
        public EqnSegment EqnSegment { get; set; } // EQN - Número de equipo
        public PcdSegment PcdSegment { get; set; } // PCD - Información de precio
        public MoaSegment MoaSegment { get; set; } // MOA - Monto
        public QtySegment QtySegment { get; set; } // QTY - Cantidad
    }
}
