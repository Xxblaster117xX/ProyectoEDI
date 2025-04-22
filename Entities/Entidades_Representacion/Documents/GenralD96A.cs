using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion.Segments;
using Entities.Entidades_Representacion.Segments.GroupSegments.GenralD96A;

namespace Entities.Entidades_Representacion.Documents
{
    public class GenralD96A
    {
        public UnhSegment unhSegment { get; set; }
        public BgmSegment bgmSegment { get; set; }
        public DtmSegment dtmSegment { get; set; }
        public GenralD96ASg1 genralD96ASg1 { get; set; }
        public GenralD96ASg2 genralD96ASg2 { get; set; }
        public GenralD96ASg5 genralD96ASg5 { get; set; }
        public UntSegment untSegment { get; set; }

    }
}
