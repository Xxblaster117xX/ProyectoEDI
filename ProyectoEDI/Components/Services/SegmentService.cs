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

        // Método para actualizar un segmento en la lista de segmentos
        public void UpdateSegment(Segment segment)
        {
            var existingSegment = _segments.FirstOrDefault(s => s.SegmentId == segment.SegmentId);
            if (existingSegment != null)
            {
                // Aquí actualizamos las propiedades del segmento encontrado
                existingSegment.SegmentCode = segment.SegmentCode;
                existingSegment.SegmentName = segment.SegmentName;
                existingSegment.SegmentDescription = segment.SegmentDescription;
                existingSegment.Obligatory = segment.Obligatory;



                Console.WriteLine($"Segmento con ID {segment.SegmentId} actualizado.");
            }
            else
            {
                Console.WriteLine("Segmento no encontrado.");
            }
        }

    }
}
