using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    public class SegmentPosition
    {
        public int Position { get; set; }
        public DataElement DataElement{ get; set; }
        public CompositeDataElement CompositeDataElement { get; set; }
    }
}
