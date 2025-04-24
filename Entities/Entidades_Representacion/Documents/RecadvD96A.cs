using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion.Segments;
using Entities.Entidades_Representacion.Segments.GroupSegments.RecadvD96A;

namespace Entities.Entidades_Representacion.Documents
{
    public class RecadvD96A
    {
        public UnhSegment unhSegment { get; set; }
        public BgmSegment bgmSegment { get; set; }
        public DtmSegment dtmSegment { get; set; }
        public AliSegment aliSegment { get; set; }
        public RecadvD96ASg1 recadvD96ASg1 { get; set; }
        public RecadvD96ASg2 recadvD96ASg2 { get; set; }
        public RecadvD96ASg4 recadvD95ASg4 { get; set; }
        public RecadvD96ASg7 recadvD96ASg7 { get; set; }
        public RecadvD96ASg10 recadvD96ASg10 { get; set; }
        public RecadvD96ASg11 recadvD96ASg11 { get; set; }
        public RecadvD96ASg16 recadvD96ASg16 { get; set; }
        public CntSegment cntSegment { get; set; }
        public UntSegment untSegment { get; set; }
    }
}
