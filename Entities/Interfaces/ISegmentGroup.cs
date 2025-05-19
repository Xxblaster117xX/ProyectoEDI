using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Definicion;
using Entities.Entidades_Representacion;

namespace Entities.Interfaces
{
    public interface ISegmentGroup<T> where T:class
    {
        public int Id { get; set; }
        public int NumeroGrupoSegmento { get; set; }
        public bool Obligatorio { get; set; }
        public List<Segment> Segments { get; set; }
        public List<SegmentGroup> SegmentGroups { get; set; }
    }
}
