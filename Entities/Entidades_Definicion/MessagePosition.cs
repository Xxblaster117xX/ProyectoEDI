using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
using Entities.Enum;

namespace Entities.Entidades_Definicion
{
    public class MessagePosition
    {
        public int Position { get; set; }
        public Segment Segment { get; set; }
        public ISegmentGroup SegmentGroup { get; set; }
        public RequirementIndicatorEnum RequirementIndicator { get; set; }
        public string Repetition { get; set; }
    }
}
