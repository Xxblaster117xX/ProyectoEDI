using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion.Abstract;

namespace Entities.Entidades_Definicion
{
    /// <summary>
    /// Clase que representa un mensaje permitido en una posición de mensaje
    /// </summary>
    public class MessagePermittedQualifier
    {
        /// <summary>
        /// Identificador del mensaje
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Posición del mensaje
        /// </summary>
        public MessagePosition MessagePosition { get; set; }
        /// <summary>
        /// Segmento del mensaje permitido para la posición
        /// </summary>
        public Segment Segment { get; set; }
        /// <summary>
        /// El elemento de dato permitido en el segmento para esa posición de mensaje
        /// </summary>
        public DataElement DataElement { get; set; }

        /// <summary>
        /// El qualifier permitido en el DataElement para el sgmento en esta posición de mensaje
        /// </summary>
        public DataElementQualifier DataElementQualifier { get; set; }

    }
}
