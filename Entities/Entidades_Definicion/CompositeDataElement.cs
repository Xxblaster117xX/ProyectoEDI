using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    /// <summary>
    /// Clase que representa un elemento de datos compuesto
    /// </summary>
    public class CompositeDataElement
    {
        /// <summary>
        /// Id de la definición de la posición en la base de datos
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Código del elemento compuesto
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// Nombre del elemento compuesto
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Descripción del elemento compuesto
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Indica si es obligatorio el elemento compuesto
        /// </summary>
        public bool obligatory { get; set; }
        /// <summary>
        /// Número de repeticiones del elemento compuesto
        /// </summary>
        public int repetition { get; set; }
        /// <summary>
        /// Lista de elementos de datos que componen el elemento compuesto
        /// </summary>
        public List<DataElement> DataElements { get; set; }
    }
}
