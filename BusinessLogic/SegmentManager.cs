
using BusinessLogic.Definition;
using Entities.Entidades_Representacion.Abstract;
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
        private readonly List<SegmentRepresentation> _segments;
        /// <summary>
        /// Constructor de la clase SegmentManager.
        /// </summary>
        public SegmentManager()
        {
            _segments = new List<SegmentRepresentation>();
        }
        /// <summary>
        /// Este método agrega un segmento a la lista de segmentos.
        /// </summary>
        /// <param name="segment"></param>
        public void AddSegment(SegmentRepresentation segment)
        {
            _segments.Add(segment);
        }
        /// <summary>
        /// Este método Obtiene un segmento según el código proporcionado.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public SegmentRepresentation GetSegmentByCode(int code)
        {
            return _segments.FirstOrDefault(s => s.SegmentCode == code);
        }


        /// <summary>
        /// Devulve la lista de segmentos
        /// </summary>
        /// <returns></returns>
        public List<SegmentRepresentation> GetAllSegments()
        {
            return _segments;
        }

        /// <summary>
        /// Este método verifica si un segmento tiene elementos compuestos.
        /// </summary>
        /// <param name="segment"></param>
        /// <returns></returns>
        public bool HasCompositeElements(SegmentRepresentation segment)
        {
            return segment.SegmentPositions.Any(p => p.CompositeDataElement != null);
        }

        public void CheckSegment(SegmentRepresentation segment)

        {

            if (segment == null)

            {

                throw new ArgumentNullException(nameof(segment), "El segmento no puede ser nulo.");

            }

            if (string.IsNullOrWhiteSpace(segment.SegmentName))

            {

                throw new ArgumentException("El nombre del segmento no puede estar vacío.", nameof(segment.SegmentName));

            }

            if (string.IsNullOrWhiteSpace(segment.SegmentDescription))

            {

                throw new ArgumentException("La descripción del segmento no puede estar vacía.", nameof(segment.SegmentDescription));

            }

            if (segment.SegmentPositions == null || segment.SegmentPositions.Count == 0)

            {

                throw new ArgumentException("El segmento debe tener al menos una posición.", nameof(segment.SegmentPositions));

            }

        }

    }
}
