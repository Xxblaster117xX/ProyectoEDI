using Entities.Entidades_Definicion;
using BusinessLogic.Definition;
using Entities.Entidades_Representacion.Abstract;
using SegmentDefinition = Entities.Entidades_Definicion.SegmentDefinition;
namespace BusinessLogic
{

    public class SegmentManager : ISegmentManager
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
 

        public List<SegmentDefinition> GetAllSegments()
        {
            return _segments;
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
        public SegmentDefinition GetSegmentByCode(int code)
        {
            return _segments.FirstOrDefault(s => s.SegmentCode == code);
        }


        /// <summary>
        /// Devulve la lista de segmentos
        /// </summary>
        /// <returns></returns>
     

        /// <summary>
        /// Este método verifica si un segmento tiene elementos compuestos.
        /// </summary>
        /// <param name="segment"></param>
        /// <returns></returns>
        public bool HasCompositeElements(SegmentDefinition segment)
        {
            return segment.SegmentPositions.Any(p => p.CompositeDataElement != null);
        }

        public SegmentDefinition GetSegmentByCode(string code)
        {
            throw new NotImplementedException();
        }
    }
}
