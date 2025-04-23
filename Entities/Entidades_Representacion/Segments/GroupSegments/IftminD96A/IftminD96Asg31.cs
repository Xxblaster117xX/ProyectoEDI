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
        public TccSegment tccSegment { get; set; } // TCC - Código de tipo de carga
        public CuxSegment cuxSegment { get; set; } // CUX - Código de moneda
        public PriSegment priSegment { get; set; } 

         public  EqnSegment eqnSegment { get; set; } // EQN - Número de equipo
          public PcdSegment pcdSegment { get; set; } // PCD - Código de peso
        public MoaSegment moaSegment { get; set; } // MOA - Monto
        public QtySegment qtySegment { get; set; } // QTY - Cantidad
        public LocSegment LocSegment { get; set; } // LOC - Ubicación
    }
}
