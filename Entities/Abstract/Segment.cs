using Entities.Entidades_Definicion;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public abstract class Segment : ISegment
    {
        public int SegmentId { get; set; }
        public int SegmentCode { get; set; }
        public string SegmentName { get; set; }
        public string SegmentDescription { get; set; }
        public List<SegmentPosition> SegmentPositions { get; set; }


    }
}
