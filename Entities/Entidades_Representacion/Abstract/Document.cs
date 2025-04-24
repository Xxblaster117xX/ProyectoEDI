using Entities.Entidades_Representacion.Abstract;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 namespace Entities.Entidades_Representacion.Abstract
{ 
    public abstract class Document : IDocument
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Segment Segment { get; set; }
    
    }
}
