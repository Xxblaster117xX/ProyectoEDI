using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Definicion;
using Entities.Entidades_Representacion;
namespace Entities.Entidades_Representacion.Abstract
{
    public class SegmentGroup
    {

        public int SegmentGroupNumber { get; set; }
        public List<Segment> SegmentList { get; set; }

        public List<SegmentGroup> SegmentGroupList { get; set; }
    }
}
