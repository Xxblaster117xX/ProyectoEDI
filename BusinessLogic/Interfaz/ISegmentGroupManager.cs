using Entities.Entidades_Definicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaz
{
    public interface ISegmentGroupManager
    {
        void AddSegmentGroup(SegmentGroup SegmentGroup);
        
        List<SegmentGroup> GetAllSegmentsGroup();

        void UpdateSegmentGroup(SegmentGroup SegmentGroup);

        SegmentGroup GetSegmentGroupById(int id);
    }
}
