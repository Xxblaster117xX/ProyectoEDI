
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities.Entidades_Representacion.Abstract;

namespace Entities.Entidades_Representacion.Segments
{
    public class TodSegment : SegmentRepresentation
    {
        /*4055       TERMS OF DELIVERY OR TRANSPORT FUNCTION, CODED     C   an1..3
  4215       TRANSPORT CHARGES METHOD OF PAYMENT, CODED         C   an1..3
  C100       TERMS OF DELIVERY OR TRANSPORT                     C
     4053    Terms of delivery or transport, coded              C   an1..3
     1131    Code list qualifier                                C   an1..3
     3055    Code list responsible agency, coded                C   an1..3
     4052    Terms of delivery or transport                     C   an1..70
     4052    Terms of delivery or transport */



        //Preguntar sobre los grupos de datos de cada tipo de segmento

        public string TermsOfDeliveryOrTransportFunctionCoded { get; set; }
        public string TransportChargesMethodOfPaymentCoded { get; set; }
        public string TermsOfDeliveryOrTransportCoded { get; set; }
        public string CodeListQualifier { get; set; }
        public string CodeListResponsibleAgencyCoded { get; set; }
        public string TermsOfDeliveryOrTransport { get; set; }
        public string TermsOfDeliveryOrTransport2 { get; set; }
    }
}

