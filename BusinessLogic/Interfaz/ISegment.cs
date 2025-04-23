using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion.Abstract;
using Segment = Entities.Entidades_Definicion.Segment;
namespace BusinessLogic.Definition
{
    /// <summary>
    /// La interfaz ISegmentManager define los métodos para manejar segmentos.
    /// </summary>
    public interface ISegmentManager
    {
        void AddSegment(Segment segment);
        Segment GetSegmentByCode(int code);
        List<Segment> GetAllSegments();
        bool HasCompositeElements(Segment segment);

        void CheckSegment(Segment segment); 

    }
}
