using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Definicion;

namespace Entities.Entidades_Representacion.Segments
{
    public class AliSegment:Segment
    {
        // pais de origen elemento de dato 3239
        public string CountryOfOrigin { get; set; }

        // tipo de regimen elemento de dato 9213
        public string DutyRegimeType { get; set; }

        public List<string> SpecialConditions { get; set; } // condiciones especiales


    }
}
