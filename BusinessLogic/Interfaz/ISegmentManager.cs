using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities.Entidades_Representacion.Abstract;

namespace BusinessLogic.Definition
{
    /// <summary>
    /// La interfaz ISegmentManager define los métodos para manejar segmentos.
    /// </summary>
    public interface ISegmentManager
    {
        void AddSegment(SegmentRepresentation segment);
        SegmentRepresentation GetSegmentByCode(int code);
        List<SegmentRepresentation> GetAllSegments();
        bool HasCompositeElements(SegmentRepresentation segment);
        void CheckSegment(SegmentRepresentation segment); 


    }
}
