using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion.Segments;
using Entities.Entidades_Representacion.Segments.GroupSegments.DesadvD96A;

namespace Entities.Entidades_Representacion.Documents
{
    public class DesadvD96A
    {
        public UnhSegment UnhSegment { get; set; }
        public BgmSegment BgmSegment { get; set; }
        public DtmSegment DtmSegment { get; set; }
        public AliSegment AliSegment { get; set; }
        public MeaSegment MeaSegment { get; set; }
        public MoaSegment MoaSegment { get; set; }
        public Desadvd96ASg1 Desadvd96ASg1 { get; set; }
        public Desadvd96ASg2 Desadvd96ASg2 { get; set; }
        public Desadvd96ASg5 Desadvd96ASg5 { get; set; }
        public Desadvd96ASg6 Desadvd96ASg6 { get; set; }
        public Desadvd96ASg8 Desadvd96ASg8 { get; set; }
        public Desadvd96ASg10 Desadvd96ASg10 { get; set; }
        public CntSegment CntSegment { get; set; }
        public UntSegment UntSegment { get; set; }
    }
}
