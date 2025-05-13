using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    public class CodeList
    {
        public int Id { get; set; }
        // dataelement que va a acontener el listado de qualifiers validos
        public int? IdDataElement { get; set; }
        public string Name { get; set; }
        public string Description{ get; set; }

        // string para saber si es numerico o alfanumerico, 
        public string CodeFormat { get; set; }

         // lista de qualifiers validos el data element
        public List<DataElementQualifier> Qualifiers { get; set; }
    }

}
