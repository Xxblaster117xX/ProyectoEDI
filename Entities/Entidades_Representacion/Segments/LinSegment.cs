

using Entities.Entidades_Representacion.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments
{
    /*1082       LINE ITEM NUMBER                                   C   n1..6
1229       ACTION REQUEST/NOTIFICATION, CODED                 C   an1..3
C212       ITEM NUMBER IDENTIFICATION                         C
   7140    Item number                                        C   an1..35
   7143    Item number type, coded                            C   an1..3
   1131    Code list qualifier                                C   an1..3
   3055    Code list responsible agency, coded                C   an1..3
C829       SUB-LINE INFORMATION                               C
   5495    Sub-line indicator, coded                          C   an1..3
   1082    Line item number                                   C   n1..6
1222       CONFIGURATION LEVEL                                C   n1..2
7083       CONFIGURATION, CODED                               C   an1..3*/
    public class LinSegment:Segment
    {
       public string LineItemNumber { get; set; }
       public string ActionRequestNotificationCoded { get; set; }
       public string ItemNumber { get; set; }
       public string ItemNumberTypeCoded { get; set; }
       public string CodeListQualifier { get; set; }
       public string CodeListResponsibleAgencyCoded { get; set; }
       public string SubLineIndicatorCoded { get; set; }
       public string SubLineItemNumber { get; set; }
       public string ConfigurationLevel { get; set; }
       public string ConfigurationCoded { get; set; }


    }
}
