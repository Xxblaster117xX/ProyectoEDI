using Entities.Entidades_Definicion;

using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Entities.Entidades_Representacion.Abstract
{
    /// <summary>
    /// Clase abstracta que representa un segmento en un mensaje
    /// </summary>
    public abstract class Segment : ISegment
    {
        /// <summary>
        /// Id de la definición del segmento en la base de datos
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Código de identificación del segmento(ISA,IEA, etc...)
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// Nombre del segmento
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Descripción del segmento
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Posición del segmento en el mensaje
        /// </summary>
        public List<SegmentPosition> Positions { get; set; }
        /// <summary>
        /// Determina la obligatoriedad del segmento
        /// </summary>
        public bool Obligatory { get; set; }
       
    }
}
