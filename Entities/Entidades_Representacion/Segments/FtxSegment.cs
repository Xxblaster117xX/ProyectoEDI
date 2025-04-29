

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion.Abstract;

namespace Entities.Entidades_Representacion.Segments
{
    public class FtxSegment:Segment
    {

        public string TextSubjectQualifier { get; set; } // Calificador del tema del texto
        public string FreeText { get; set; } // Texto libre
        public string FreeTextCode { get; set; } // Código de texto libre

    }
}
