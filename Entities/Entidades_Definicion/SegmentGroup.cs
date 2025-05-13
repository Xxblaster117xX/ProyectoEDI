using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    public class SegmentGroup
    {
        public int Id { get; set; }
        public int NumeroGrupoSegmentos { get; set; }
        public bool Obligatorio { get; set; }
        public List<SegmentDefinition> Segments { get; set; }
        public List<SegmentGroup> SegmentsGroups { get; set; }
    }
}
