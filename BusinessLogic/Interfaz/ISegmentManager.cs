using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities.Entidades_Definicion;

namespace BusinessLogic.Definition
{
    /// <summary>
    /// La interfaz ISegmentManager define los métodos para manejar segmentos.
    /// </summary>
    public interface ISegmentManager
    {
        void AddSegment(SegmentDefinition segment);
        SegmentDefinition GetSegmentByCode(string code);
        List<SegmentDefinition> GetAllSegments();
        bool HasCompositeElements(SegmentDefinition segment);
       


    }
}
