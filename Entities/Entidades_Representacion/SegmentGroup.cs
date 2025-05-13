using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Definicion;
using Entities.Entidades_Representacion;
namespace Entities.Entidades_Representacion.Abstract
{
    public class SegmentGroup
    {
        /// <summary>
        /// Id de la definición de la posición en la base de datos
        /// </summary>
        public int id { get; set; }
        public int SegmentGroupNumber { get; set; }
        public bool obligatory { get; set; }
        /// <summary>
        /// Listado de segmentos del segment group
        /// </summary>
        public List<Segment> SegmentList { get; set; }

        /// <summary>
        /// Listado de grupos de segmento
        /// </summary>
        public List<SegmentGroup> SegmentGroupList { get; set; }
    }
}
