using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    public class CompositeDataElement
    {
       // usamos data anotations para las validaciones
        public int Id {  get; set; }

        [Required(ErrorMessage = "El campo Código es obligatorio.")]
        public string Code { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Obligatory { get; set; }

        public int Repeticiones { get; set; }
        public List<DataElement> DataElements { get; set; }= new List<DataElement>();
    }
}
