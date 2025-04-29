using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enum;
using Entities.Entidades_Representacion.Abstract;
using Entities.Entidades_Representacion;

namespace Entities.Entidades_Definicion
{
    public class MessagePosition
    {
        public int Position { get; set; }
        public SegmentDefinition Segment { get; set; }
        public SegmentGroup SegmentGroup { get; set; }
        public RequirementIndicatorEnum RequirementIndicator { get; set; }
        public string Repetition { get; set; }
    }
}
