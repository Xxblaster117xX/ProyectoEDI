using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    public class DataElement
    {
        public int Id { get; set; }
        public int Code {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ValueFormat { get; set; }
        public List<CodeList> CodeLists { get; set; }

    }
}
