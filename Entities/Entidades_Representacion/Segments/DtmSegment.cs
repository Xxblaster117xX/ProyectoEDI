using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Entities.Entidades_Representacion.Abstract;


namespace Entities.Entidades_Representacion.Segments
{
    public class DtmSegment : Segment
    {
        // indica el tipo de fecha y es Mandatory
        public string DateQualifier { get; set; } 
        public string DateTimePeriod { get; set; } // periodo o fecha en formato YYMMDD y es Conditional
        public string DateTimePeriodFormat { get; set; } // formato de la fecha o periodo

    }
}
