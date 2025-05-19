using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    public class CompositeDataElement
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Obligatory { get; set; }
        public int Repetition { get; set; }
        public List<DataElement> DataElements { get; set; }
    }
}
