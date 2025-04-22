using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Entidades_Representacion.Segments
{
    public class DtmSegment : Segment
    {
        // indica el tipo de fecha y es Mandatory
        public string dateQualifier { get; set; } 
        public string dateTimePeriod { get; set; } // periodo o fecha en formato YYMMDD y es Conditional
        public string dateTimePeriodFormat { get; set; } // formato de la fecha o periodo

    }
}
