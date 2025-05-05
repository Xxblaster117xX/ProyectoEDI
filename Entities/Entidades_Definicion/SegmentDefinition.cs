using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    public class SegmentDefinition
    {
        public int SegmentId { get; set; }
        public string SegmentCode { get; set; }
        public string SegmentName { get; set; }
        public string SegmentDescription { get; set; }
        public bool Obligatory { get; set; } = false;
        public List<SegmentPosition>  SegmentPositions { get; set; }
        
    }
}
