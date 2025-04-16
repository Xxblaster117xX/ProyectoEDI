using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace BusinessLogic.Definition
{
    /// <summary>
    /// La interfaz ISegmentManager define los métodos para manejar segmentos.
    /// </summary>
    public interface ISegmentManager
    {
        void AddSegment(Segment segment);
        Segment GetSegmentByCode(string code);
        List<Segment> GetAllSegments();
        bool HasCompositeElements(Segment segment);



    }
}
