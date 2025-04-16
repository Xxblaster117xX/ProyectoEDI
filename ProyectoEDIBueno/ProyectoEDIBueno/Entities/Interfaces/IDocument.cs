using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IDocument
    {
        string Name { get; set; }
        string Description { get; set; }
        Segment Segment { get; set; }

    }
}
