using Entities.Entidades_Representacion.Abstract;

namespace ProyectoEDI.Components.Services
{
    public class SegmentService
    {
        private readonly List<Segment> _segments = new List<Segment>();

        // método para obtener todos los segmentos
        public List<Segment> GetSegments()
        {
            return _segments;
        }

        // método para añadir un segmento a la lista de segmentos
        public void AddSegment(Segment segment)
        {
            if (segment != null)
            {
                _segments.Add(segment);
                Console.WriteLine($"Segmento agregado: {segment.SegmentName}");
            }
            else
            {
                Console.WriteLine("El segmento es nulo");
            }
        }

    }
}
