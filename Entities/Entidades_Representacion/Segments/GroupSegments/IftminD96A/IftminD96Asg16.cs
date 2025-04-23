using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.IftminD96A
{
    public class IftminD96Asg16
    {
        public CpiSegment cpiSegment { get; set; } // Carga de la unidad de transporte
        public RffSegment rffSegment { get; set; } // Referencia
        public CuxSegment cuxSegment { get; set; } // Divisa
        public LocSegment locSegment { get; set; } // Lugar
        public MoaSegment moaSegment { get; set; } // Monto
    }
}
