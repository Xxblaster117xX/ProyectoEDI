using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion.Abstract;

namespace Entities.Entidades_Representacion
{
    public class SegmentGroup
    {
        public int Id { get; set; }
        public int NumeroGrupoSegmento { get; set; }
        public bool Obligatorio { get; set; }
        public List<Segment> Segments { get; set; }
        public List<SegmentGroup> SegmentGroups { get; set; }
    }
}
