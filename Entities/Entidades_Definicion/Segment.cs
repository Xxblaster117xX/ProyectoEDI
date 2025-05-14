using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    /// <summary>
    /// Clase que representa un segmento en un mensaje
    /// </summary>
    public class Segment
    {
        /// <summary>
        /// Id de la definición de la posición en la base de datos
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Código del segmento(0010,0020, etc...)
        /// </summary>
        public int SegmentCode { get; set; }
        /// <summary>
        /// Nombre del segmento
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Descripción del segmento
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Posición que ocupa el segmento en el mensaje
        /// </summary>
        public List<SegmentPosition>  Positions { get; set; }

    }
}
