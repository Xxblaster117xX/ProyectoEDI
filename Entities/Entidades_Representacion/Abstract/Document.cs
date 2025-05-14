using Entities.Entidades_Representacion.Abstract;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Entities.Entidades_Representacion.Abstract
{
    /// <summary>
    /// Clase abstracta que representa un documento en el sistema.
    /// </summary>
    public abstract class Document : IDocument
    {
        public int id { get; set; }

        /// <summary>
        /// Nombre del documento
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Descripción del documento
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Segmento del documento
        /// </summary>
        public Segment Segment { get; set; }
    
    }
}
