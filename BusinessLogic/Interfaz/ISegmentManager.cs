using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Definicion;


using Entities.Entidades_Representacion.Abstract;
using Segment = Entities.Entidades_Definicion.Segment;

namespace BusinessLogic.Definition
{
    /// <summary>
    /// La interfaz ISegmentManager define los métodos para manejar segmentos.
    /// </summary>
    public interface ISegmentManager
    {
        /// <summary>
        /// Método para agregar un nuevo segmento a la lista.
        /// </summary>
        /// <param name="segment"></param>
        void AddSegment(Segment segment);
        /// <summary>
        /// Método para obtener un segmento según su código.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        Segment GetSegmentByCode(int code);
        /// <summary>
        /// Método para obtener la lista de segmentos
        /// </summary>
        /// <returns></returns>
        List<Segment> GetAllSegments();
        /// <summary>
        /// Método para verificar si un segmento tiene elementos compuestos.
        /// </summary>
        /// <param name="segment"></param>
        /// <returns></returns>
        bool HasCompositeElements(Segment segment);
     


    }
}
