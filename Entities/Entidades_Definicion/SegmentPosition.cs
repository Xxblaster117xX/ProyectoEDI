using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    public class SegmentPosition
    {
        public int Id { get; set; }
        /*
         identificador visual a nivel de posicion de segmento (0010, 0120 etc..)
        
         */
        public int Position { get; set; }
        public DataElement DataElement{ get; set; }
        public CompositeDataElement CompositeDataElement { get; set; }
    }
}
