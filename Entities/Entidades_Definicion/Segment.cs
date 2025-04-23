using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    public class Segment
    {
        public int SegmentCode { get; set; }
        public string SegmentName { get; set; }
        public string SegmentDescription { get; set; }
        public List<SegmentPosition> SegmentPositions { get; set; }




    }
}
