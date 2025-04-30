using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion.Abstract;

namespace Entities.Entidades_Representacion
{
    public class SegmentGroup
    {
        public string SegmentGroupCode { get; set; }
        public List<Segment> SegmentsList { get; set; }
        public List<SegmentGroup> SegmentGroupsList { get; set; }
    }
}
