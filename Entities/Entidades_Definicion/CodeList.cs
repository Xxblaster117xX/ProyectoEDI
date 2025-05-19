using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    public class CodeList
    {
        public int Id { get; set; } // Identificador único para el CodeList
        public DataElement DataElement { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string CodeFormat { get; set; }

        
         // lista de objetos de tipo DataElementQualifier
         
        public List<DataElementQualifier> Qualifiers { get; set; }
    }

}
