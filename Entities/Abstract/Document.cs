using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<<< HEAD:Entities/Abstract/Document.cs
namespace Entities.Abstract
========
namespace Entities.Entidades_Representacion.Abstract
>>>>>>>> origin/Antonio:Entities/Entidades_Representacion/Abstract/Document.cs
{
    public abstract class Document : IDocument
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Segment Segment { get; set; }
    }
}
