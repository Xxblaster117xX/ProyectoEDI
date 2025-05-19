using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    public class SegmentDefinition
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<SegmentPosition> SegmentPositions { get; set; }


    }
}
