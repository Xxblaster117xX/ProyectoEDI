using Entities.Entidades_Definicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface ISegment
    {
        int SegmentId { get; set; }
        string SegmentCode { get; set; }
        string SegmentName { get; set; }
        string SegmentDescription { get; set; }
        List<SegmentPosition> SegmentPositions { get; set; }
        bool Obligatory { get; set; }
    }
}
