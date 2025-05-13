using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Definicion
{
    public class SegmentGroup
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debes indicar los números para los grupos de segmentos.")]
        public int NumeroGrupoSegmentos { get; set; }
        public bool Obligatorio { get; set; }
        public List<SegmentDefinition> Segments { get; set; } = new List<SegmentDefinition>();
        public List<SegmentGroup> SegmentsGroups { get; set; } = new List<SegmentGroup>();
    }
}
