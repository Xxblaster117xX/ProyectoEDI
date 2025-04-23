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
        public UnhSegment unhSegment { get; set; }
        public BgmSegment bgmSegment { get; set; }
        public DtmSegment dtmSegment { get; set; }
        public AliSegment aliSegment { get; set; }
        public MeaSegment meaSegment { get; set; }
        public MoaSegment moaSegment { get; set; }
        public Desadvd96ASg1 Desadvd96ASg1 { get; set; }
        public Desadvd96ASg2 Desadvd96ASg2 { get; set; }
        public Desadvd96ASg5 Desadvd96ASg5 { get; set; }
        public Desadvd96ASg6 Desadvd96ASg6 { get; set; }
        public Desadvd96ASg8 Desadvd96ASg8 { get; set; }
        public Desadvd96ASg10 Desadvd96ASg10 { get; set; }
        public CntSegment cntSegment { get; set; }
        public UntSegment untSegment { get; set; }
    }
}
