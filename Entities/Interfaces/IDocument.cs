using Entities.Entidades_Representacion.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{

    /// <summary>
    /// Interfaz que representa un documento en el sistema.
    /// </summary>
    public interface IDocument
    {
        /// <summary>
        /// Nombre del documento.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Descripción del documento.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Tipo de documento.
        /// </summary>
        public Segment Segment { get; set; }

    }
}
