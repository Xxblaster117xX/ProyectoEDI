﻿

using Entities.Entidades_Representacion.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades_Representacion.Segments
{
    public class LocSegment : Segment
    {
        /*
         Indica el tipo de localización puede ser 11, 22,92 etc...  
        
         */
        public string LocationQualifier { get; set; }

        public string LocationId { get; set; } // indica el id de la localización

        // El código de calificación para el tipo de identificación de la ubicación
        public string LocationCodeQualifier { get; set; }
    }
}
