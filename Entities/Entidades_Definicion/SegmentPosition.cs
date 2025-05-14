using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    /// <summary>
    /// Clase que representa una posición de segmento en un mensaje
    /// </summary>
    public class SegmentPosition
    {
        /// <summary>
        /// Id de la definición de la posición en la base de datos
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Identificador visual a nivel de posición del segmento(0010, 0120, etc...)
        /// </summary>
        public int Position { get; set; }
        /// <summary>
        /// Elemento de dato que tiene la posición del segmento
        /// </summary>
        public DataElement DataElement{ get; set; }
        /// <summary>
        /// Elemento de dato padre que tiene la posición del dataElement
        /// </summary>
        public CompositeDataElement CompositeDataElement { get; set; }

    }
}
