using AppLayer.Interfaces;
using Entities.Entidades_Definicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLayer
{
    public class SegmentAppService:ISegmentAppService
    {
        /// <summary>
        /// La clase se encarga de manejejar el segmento y su propiedades.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="segment"></param>
        /// <exception cref="ArgumentNullException"></exception>
        private readonly List<SegmentDefinition> _segments;
        /// <summary>
        /// Constructor de la clase SegmentManager.
        /// </summary>
        /// 

        private int contador = 0;

        public int AutoIncrement()
        {
            return ++contador;
        }

        public SegmentAppService()
        {
            _segments = new List<SegmentDefinition>();
        }
        /// <summary>
        /// Este método agrega un segmento a la lista de segmentos.
        /// </summary>
        /// <param name="segment"></param>
        public void AddSegment(SegmentDefinition segment)
        {
            _segments.Add(segment);
        }
        /// <summary>
        /// Este método Obtiene un segmento según el código proporcionado.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public SegmentDefinition GetSegmentByCode(string code)
        {
            return _segments.FirstOrDefault(s => s.SegmentCode.Equals(code));
        }


        /// <summary>
        /// Devulve la lista de segmentos
        /// </summary>
        /// <returns></returns>
        public List<SegmentDefinition> GetAllSegments()
        {
            return _segments;
        }

        /// <summary>
        /// Este método verifica si un segmento tiene elementos compuestos.
        /// </summary>
        /// <param name="segment"></param>
        /// <returns></returns>
        public bool HasCompositeElements(SegmentDefinition segment)
        {
            return segment.SegmentPositions.Any(p => p.CompositeDataElement != null);
        }

    }
}
