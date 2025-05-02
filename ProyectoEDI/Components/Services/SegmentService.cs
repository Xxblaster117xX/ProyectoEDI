
using Entities.Entidades_Definicion;

namespace ProyectoEDI.Components.Services
{
    public class SegmentService
    {
        private  List<SegmentDefinition> _segments = new List<SegmentDefinition>();

        // método para obtener todos los segmentos
        public List<SegmentDefinition> GetSegments()
        {
            return _segments;
        }

        // método para añadir un segmento a la lista de segmentos
        public void AddSegment(SegmentDefinition segment)
        {
            if (segment != null)
            {
                _segments.Add(segment);
            }
        }

        // método para obtener el tipo de segmento para mostrarlo en la vista lista de segmentos
        public string GetTypeSegment(SegmentDefinition segment) {
            // devolvemos el nombre del tipo de segmento
            return segment.GetType().Name;
        }

    }
}
