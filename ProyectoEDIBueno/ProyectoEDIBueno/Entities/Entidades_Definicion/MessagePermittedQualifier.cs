using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Entidades_Definicion
{
    public class MessagePermittedQualifier
    {
        public MessagePosition MessagePosition;
        public Segment Segment { get; set; }
        public DataElement DataElement { get; set; }
        public DataElementQualifier Qualifier { get; set; }

    }
}
