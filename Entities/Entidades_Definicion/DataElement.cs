using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    public class DataElement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DataElementId { get; set; }
        public int Code {  get; set; }
        public List<CodeList> CodeLists { get; set; } = new List<CodeList>();

        public string DataElementName { get; set; }
        public string DataElementDescription { get; set; }
        public string DataElementValueFormat { get; set; }

    }
}
