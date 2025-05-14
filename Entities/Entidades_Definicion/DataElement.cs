using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    /// <summary>
    /// Clase que representa un elemento de datos en el sistema.
    /// </summary>
    public class DataElement
    {
        /// <summary>
        /// Id de la definición de la posición en la base de datos
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Código de identificación del data element(7123,4205, etc...)
        /// </summary>
        public int Code {  get; set; }
     
        /// <summary>
        /// Nombre del data element
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///  Descripción del data element
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Formato que determina si es numérico, mínimo de caracteres, máximo de caracteres, etc...
        /// </summary>
        public string ValueFormat { get; set; }

      /// <summary>
      /// Determina si el data element es obligatorio
      /// </summary>
        public bool obligatory { get; set; }
        /// <summary>
        ///  Determina el nº de veces que la posición del segmento puede repetirse en el segmento
        /// </summary>
        public int repetition { get; set; }

        /// <summary>
        /// El code list que tiene el data element asociado
        /// </summary>
        public List<CodeList> CodeLists { get; set; } = new List<CodeList>();

    }
}
