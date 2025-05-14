using Entities.Entidades_Definicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLayer.Interfaces
{
    public interface ISegmentAppService
    {
        void AddSegment(SegmentDefinition segment);
        SegmentDefinition GetSegmentByCode(string code);
        List<SegmentDefinition> GetAllSegments();
        bool HasCompositeElements(SegmentDefinition segment);

    }
}
