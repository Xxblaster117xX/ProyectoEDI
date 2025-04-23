using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion.Segments;

namespace Entities.Entidades_Representacion.Documents
{
    public class DelforD96A
    {
        public UnhSegment unhSegment { get; set; }
        public BgmSegment bgmSegment { get; set; }
        public DtmSegment dtmSegment { get; set; }
        public DelforD96ASg1 delforD96ASg1 { get; set; }
        public DelforD96ASg2 delforD96ASg2 { get; set; }
        public UnsSegment unsSegment { get; set; }
        public DelforD96ASg4 delforD96ASg4 { get; set; }
        public DelforD96ASg18 delforD96ASg18 { get; set; }
        public UnsSegment unsSegment2 { get; set; }
        public CntSegment cntSegment { get; set; }
        public FtxSegment ftxSegment { get; set; }
        public UntSegment untSegment { get; set; }
    }
}
