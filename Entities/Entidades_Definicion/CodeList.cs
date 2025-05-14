using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    /// <summary>
    /// Clase que representa una lista de códigos
    /// </summary>
    public class CodeList
    {
        /// <summary>
        /// Id de la definición de la posición en la base de datos
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Código del elemento de datos
        /// </summary>
        public int?  IdDataElement { get; set; }
        /// <summary>
        ///Nombre de la lista de códigos
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Descripción de la lista de códigos
        /// </summary>
        public string Description{ get; set; }

        /// <summary>
        /// formato de la lista de códigos
        /// </summary>
        public string CodeFormat { get; set; }

        
         /// <summary>
         /// lista de objetos de tipo DataElementQualifier
         /// </summary>
         
        public List<DataElementQualifier> Qualifiers { get; set; }
    }

}
