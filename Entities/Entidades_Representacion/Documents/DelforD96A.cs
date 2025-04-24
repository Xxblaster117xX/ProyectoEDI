using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion.Segments;
using Entities.Entidades_Representacion.Segments.GroupSegments.DelforD96A;

namespace Entities.Entidades_Representacion.Documents
{
    public class DelforD96A
    {
        public UnhSegment UnhSegment { get; set; }
        public BgmSegment BgmSegment { get; set; }
        public DtmSegment DtmSegment { get; set; }
        public DelforD96ASg1 DelforD96ASg1 { get; set; }
        public DelforD96ASg2 DelforD96ASg2 { get; set; }
        public UnsSegment UnsSegment { get; set; }
        public DelforD96ASg4 DelforD96ASg4 { get; set; }
        public DelforD96ASg18 DelforD96ASg18 { get; set; }
        public UnsSegment UnsSegment2 { get; set; }
        public CntSegment CntSegment { get; set; }
        public FtxSegment FtxSegment { get; set; }
        public UntSegment UntSegment { get; set; }
    }
}
