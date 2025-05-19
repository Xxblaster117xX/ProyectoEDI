using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion;
using Entities.Entidades_Representacion.Abstract;

namespace Entities.Entidades_Representacion.Segments
{
    /*C524       HANDLING INSTRUCTIONS                              C
   4079    Handling instructions, coded                       C   an1..3
   1131    Code list qualifier                                C   an1..3
   3055    Code list responsible agency, coded                C   an1..3
   4078    Handling instructions                              C   an1..70
C218       HAZARDOUS MATERIAL                                 C
   7419    Hazardous material class code, identification      C   an1..4
   1131    Code list qualifier                                C   an1..3
   3055    Code list responsible agency, coded                C   an1..3*/
    public class HanSegment : Segment
    {
        public string HandlingInstructionsCoded { get; set; }
        public Entidades_Definicion.CodeList HanCodeListQualifier { get; set; }
        public string CodeListResponsibleAgencyCoded { get; set; }
        public string HandlingInstructions { get; set; }
        public string HazardousMaterialClassCodeIdentification { get; set; }
        public string HazardousMaterialClassCode { get; set; }
        public string HanCodeListQualifier2 { get; set; }



    }
}
