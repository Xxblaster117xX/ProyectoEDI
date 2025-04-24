using Entities.Entidades_Definicion;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<<< HEAD:Entities/Abstract/Segment.cs
namespace Entities.Abstract
{
    public abstract class Segment : ISegment
    {
        public int SegmentId { get; set; }
========
namespace Entities.Entidades_Representacion.Abstract
{
    public abstract class Segment : ISegment
    {
>>>>>>>> origin/Antonio:Entities/Entidades_Representacion/Abstract/Segment.cs
        public int SegmentCode { get; set; }
        public string SegmentName { get; set; }
        public string SegmentDescription { get; set; }
        public List<SegmentPosition> SegmentPositions { get; set; }
<<<<<<<< HEAD:Entities/Abstract/Segment.cs
        public bool Obligatorio { get; set; }
========


>>>>>>>> origin/Antonio:Entities/Entidades_Representacion/Abstract/Segment.cs

    }
}
