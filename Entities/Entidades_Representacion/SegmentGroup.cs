using Entities.Entidades_Representacion.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion
{
    public class SegmentGroup
    {
        public int SegmentGroupNumber{ get; set; }
        public List<SegmentRepresentation> SegmentsList { get; set; }
        public List<SegmentGroup> SegmentsGroupsList { get; set; }
        public bool obligatory { get; set; }

    }
}
