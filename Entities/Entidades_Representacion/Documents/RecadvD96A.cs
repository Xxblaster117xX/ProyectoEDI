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
        public UnhSegment UnhSegment { get; set; }
        public BgmSegment BgmSegment { get; set; }
        public DtmSegment DtmSegment { get; set; }
        public AliSegment AliSegment { get; set; }
        public RecadvD96ASg1 RecadvD96ASg1 { get; set; }
        public RecadvD96ASg2 RecadvD96ASg2 { get; set; }
        public RecadvD96ASg4 RecadvD95ASg4 { get; set; }
        public RecadvD96ASg7 RecadvD96ASg7 { get; set; }
        public RecadvD96ASg10 RecadvD96ASg10 { get; set; }
        public RecadvD96ASg11 RecadvD96ASg11 { get; set; }
        public RecadvD96ASg16 RecadvD96ASg16 { get; set; }
        public CntSegment CntSegment { get; set; }
        public UntSegment UntSegment { get; set; }
    }
}
