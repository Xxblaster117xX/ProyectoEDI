using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion.Segments;

namespace Entities.Entidades_Representacion.Documents
{
    public class IftminD96A
    {
        public UnhSegment UnhSegment { get; set; }
        public BgmSegment BgmSegment { get; set; }
        public CtaSegment CtaSegment { get; set; }
        public ComSegment ComSegment { get; set; }
        public DtmSegment DtmSegment { get; set; }
        public CuxSegment CuxSegment { get; set; }
        public MoaSegment MoaSegment { get; set; }
        public FtxSegment FtxSegment { get; set; }
        public CntSegment CntSegment { get; set; }
        public DocSegment DocSegment { get; set; }
    }
}
