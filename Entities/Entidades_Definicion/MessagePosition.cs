using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities.Entidades_Representacion.Abstract;
using Entities.Entidades_Representacion;

namespace Entities.Entidades_Definicion
{
    /// <summary>
    /// Clase que representa una posición de mensaje en un mensaje
    /// </summary>
    public class MessagePosition
    {
        /// <summary>
        /// Id de la definición de la posición en la base de datos
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Posición en la estructura del mensaje(010, 020,030, etc...)
        /// </summary>
        public int Position { get; set; }
      
        /// <summary>
        /// Segmento al que pertenece
        /// </summary>
        public Segment Segment { get; set; }
       /// <summary>
       /// Determina el grupo de segmento al que pertenece
       /// </summary>
        public SegmentGroup SegmentGroup { get; set; }
   
        /// <summary>
        /// Determina si esa posición de mensaje debe exisitir sí o sí
        /// </summary>
        public bool obligatory { get; set; }
        /// <summary>
        /// Determina el nº de veces que la posición del segmento puede repetirse en el mensaje/grupo de segmento
        /// </summary>
        public string Repetition { get; set; }
    }
}
