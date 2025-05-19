using Entities.Entidades_Definicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface ISegment
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public bool Obligatorio { get; set; }
        public List<SegmentPosition> SegmentPositions { get; set; }
    }
}
