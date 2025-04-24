using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.IftminD96A
{
    public class IftminD96Asg31
    {
        public TccSegment TccSegment { get; set; } // TCC - Código de tipo de carga
        public CuxSegment CuxSegment { get; set; } // CUX - Código de moneda
        public PriSegment PriSegment { get; set; } 

         public  EqnSegment EqnSegment { get; set; } // EQN - Número de equipo
          public PcdSegment PcdSegment { get; set; } // PCD - Código de peso
        public MoaSegment MoaSegment { get; set; } // MOA - Monto
        public QtySegment QtySegment { get; set; } // QTY - Cantidad
        public LocSegment LocSegment { get; set; } // LOC - Ubicación
    }
}
