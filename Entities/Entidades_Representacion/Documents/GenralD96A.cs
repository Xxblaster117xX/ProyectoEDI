using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion.Segments;
using Entities.Entidades_Representacion.Segments.GroupSegments.GenralD96A;

namespace Entities.Entidades_Representacion.Documents
{
    public class GenralD96A
    {
        public UnhSegment UnhSegment { get; set; }
        public BgmSegment BgmSegment { get; set; }
        public DtmSegment DtmSegment { get; set; }
        public GenralD96ASg1 GenralD96ASg1 { get; set; }
        public GenralD96ASg2 GenralD96ASg2 { get; set; }
        public GenralD96ASg5 GenralD96ASg5 { get; set; }
        public UntSegment UntSegment { get; set; }

    }
}
