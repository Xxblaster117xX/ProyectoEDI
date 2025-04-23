using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion.Segments;

namespace Entities.Entidades_Representacion.Documents
{
    public class InvoicD96A
    {
        public UnhSegment unhSegment {  get; set; }
        public BgmSegment bgmSegment { get; set; }
        public DtmSegment dtmSegment { get; set; }
        public PaiSegment paiSegment { get; set; }
        public AliSegment aliSegment { get; set; }
        public ImdSegment imdSegment { get; set; }
        public FtxSegment ftxSegment { get; set; }
        public UnsSegment unsSegment { get; set; }
        public CntSegment cntSegment { get; set; }
        public UntSegment untSegment { get; set; }

    }
}
