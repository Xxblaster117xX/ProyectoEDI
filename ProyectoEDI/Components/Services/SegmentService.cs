using Entities.Entidades_Representacion.Abstract;

namespace ProyectoEDI.Components.Services
{
    public class SegmentService
    {
        private readonly List<SegmentRepresentation> _segments = new List<SegmentRepresentation>();

        // método para obtener todos los segmentos
        public List<SegmentRepresentation> GetSegments()
        {
            return _segments;
        }

        // método para añadir un segmento a la lista de segmentos
        public void AddSegment(SegmentRepresentation segment)
        {
            if (segment != null)
            {
                _segments.Add(segment);
            }
        }

    }
}
