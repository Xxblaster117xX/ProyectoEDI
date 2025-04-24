using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments.GroupSegments.IftminD96A
{
    public class IftminD96Asg16
    {
        public CpiSegment CpiSegment { get; set; } // Carga de la unidad de transporte
        public RffSegment RffSegment { get; set; } // Referencia
        public CuxSegment CuxSegment { get; set; } // Divisa
        public LocSegment LocSegment { get; set; } // Lugar
        public MoaSegment MoaSegment { get; set; } // Monto
    }
}
