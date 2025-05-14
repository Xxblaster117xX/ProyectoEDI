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
        public required string Qualifier { get; set; } 
        public DateTime DateTimeValue { get; set; } // periodo o fecha en formato YYMMDD y es Conditional

        public Period? PeriodValue { get; set; }
        public string FormatQualifier { get; set; } // formato de la fecha o periodo

    }

    public class Period
    {
        public DateTime DateTimeFrom { get; set; }
        public DateTime DateTimeTo { get; set; }
    }
}
