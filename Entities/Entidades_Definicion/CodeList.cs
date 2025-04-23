using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    public class CodeList
    {
        public DataElement DataElement { get; set; }
        public string Name { get; set; }
        public string Description{ get; set; }
        public string CodeFormat { get; set; }

        
         // lista de objetos de tipo DataElementQualifier
         
        public List<DataElementQualifier> Qualifiers { get; set; }
    }

}
