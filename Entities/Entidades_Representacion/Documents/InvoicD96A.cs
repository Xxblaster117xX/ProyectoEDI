using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion.Segments;
using Entities.Entidades_Representacion.Segments.GroupSegments.InvoicD96A;

namespace Entities.Entidades_Representacion.Documents
{
    public class InvoicD96A
    {
        public UnhSegment UnhSegment {  get; set; }
        public BgmSegment BgmSegment { get; set; }
        public DtmSegment DtmSegment { get; set; }
        public PaiSegment PaiSegment { get; set; }
        public AliSegment AliSegment { get; set; }
        public ImdSegment ImdSegment { get; set; }
        public FtxSegment FtxSegment { get; set; }
        public InvoicD96ASg1 InvoicD96ASg1 { get; set; }
        public InvoicD96ASg2 InvoicD96ASg2 { get; set; }
        public InvoicD96ASg6 InvoicD96ASg6 { get; set; }
        public InvoicD96ASg7 InvoicD96ASg7 { get; set; }
        public InvoicD96ASg8 InvoicD96ASg8 { get; set; }
        public InvoicD96ASg9 InvoicD96ASg9 { get; set; }
        public InvoicD96ASg12 InvoicD96ASg12 { get; set; }
        public InvoicD96ASg13 InvoicD96ASg13 { get; set; }
        public InvoicD96ASg15 InvoicD96ASg15 { get; set; }
        public InvoicD96ASg22 InvoicD96ASg22 { get; set; }
        public InvoicD96ASg23 InvoicD96ASg23 { get; set; }
        public InvoicD96ASg24 InvoicD96ASg24 { get; set; }
        public InvoicD96ASg25 InvoicD96ASg25 { get; set; }
        public InvoicD96ASg48 InvoicD96ASg48 { get; set; }
        public InvoicD96ASg50 InvoicD96ASg50 { get; set; }
        public InvoicD96ASg51 InvoicD96ASg51 { get; set; }
        public UnsSegment UnsSegment { get; set; }
        public CntSegment CntSegment { get; set; }
        public UntSegment UntSegment { get; set; }

    }
}
