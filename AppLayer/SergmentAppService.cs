using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion.Abstract;

namespace AppLayer
{
    public class SergmentAppService
    {
        /// <summary>
        /// La clase se encarga de manejejar el segmento y su propiedades.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="segment"></param>
        /// <exception cref="ArgumentNullException"></exception>
        private readonly List<Segment> _segments;
        /// <summary>
        /// Constructor de la clase SegmentManager.
        /// </summary>


        public List<Segment> GetAllSegments()
        {
            return _segments;
        }

        /// <summary>
        /// Este método agrega un segmento a la lista de segmentos.
        /// </summary>
        /// <param name="segment"></param>
        public void AddSegment(Segment segment)
        {
            _segments.Add(segment);
        }
        /// <summary>
        /// Este método Obtiene un segmento según el código proporcionado.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Segment GetSegmentByCode(int code)
        {
            return _segments.FirstOrDefault(s => s.Code == code);
        }




        /// <summary>
        /// Este método verifica si un segmento tiene elementos compuestos.
        /// </summary>
        /// <param name="segment"></param>
        /// <returns></returns>
        public bool HasCompositeElements(Segment segment)
        {
            return segment.Positions.Any(p => p.CompositeDataElement != null);
        }

        /// <summary>
        /// Método para obtemer un segmento según su código.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Segment GetSegmentByCode(string code)
        {
            throw new NotImplementedException();
        }
    }


}

