using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments
{
    public class Ftx:Segment
    {

        public string textSubjectQualifier { get; set; } // Calificador del tema del texto
        public string freeText { get; set; } // Texto libre
        public string freeTextCode { get; set; } // Código de texto libre

    }
}
