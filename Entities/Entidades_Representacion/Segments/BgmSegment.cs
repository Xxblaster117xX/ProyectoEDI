
using Entities.Entidades_Representacion;
using Entities.Entidades_Representacion.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Entidades_Representacion.Segments
{
    public class BgmSegment:Segment
    {
        public int MessageNumber { get; set; } // Número de mensaje
        public string MessageName { get; set; } // Nombre del mensaje
        public int MessageFunctionCode { get; set; } // Código de función del mensaje
        
    }
}
