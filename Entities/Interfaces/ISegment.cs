using Entities.Entidades_Definicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    /// <summary>
    /// Interfaz que representa un segmento en un mensaje
    /// </summary>
    public interface ISegment
    {
        /// <summary>
        /// Id de la definición del segmento en la base de datos
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// Código de identificación del segmento(ISA,GS,ST, etc...)
        /// </summary>
        int Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        string Name { get; set; }
        string Description { get; set; }
        List<SegmentPosition> Positions { get; set; }
        bool Obligatory { get; set; }
    }
}
