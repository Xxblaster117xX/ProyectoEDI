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
        public InvoicD96ASg1 invoicD96ASg1 { get; set; }
        public InvoicD96ASg2 invoicD96ASg2 { get; set; }
        public InvoicD96ASg6 invoicD96ASg6 { get; set; }
        public InvoicD96ASg7 invoicD96ASg7 { get; set; }
        public InvoicD96ASg8 invoicD96ASg8 { get; set; }
        public InvoicD96ASg9 invoicD96ASg9 { get; set; }
        public InvoicD96ASg12 invoicD96ASg12 { get; set; }
        public InvoicD96ASg13 invoicD96ASg13 { get; set; }
        public InvoicD96ASg15 invoicD96ASg15 { get; set; }
        public InvoicD96ASg22 invoicD96ASg22 { get; set; }
        public InvoicD96ASg23 invoicD96ASg23 { get; set; }
        public InvoicD96ASg24 invoicD96ASg24 { get; set; }
        public InvoicD96ASg25 invoicD96ASg25 { get; set; }
        public InvoicD96ASg48 invoicD96ASg48 { get; set; }
        public InvoicD96ASg50 invoicD96ASg50 { get; set; }
        public InvoicD96ASg51 invoicD96ASg51 { get; set; }
        public UnsSegment unsSegment { get; set; }
        public CntSegment cntSegment { get; set; }
        public UntSegment untSegment { get; set; }

    }
}
