using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Definicion;

namespace AppLayer.Interfaces
{
    public interface ISegmentGroupAppService
    {
        void AddSegmentGroup(SegmentGroup SegmentGroup);

        List<SegmentGroup> GetAllSegmentsGroup();

        void UpdateSegmentGroup(SegmentGroup SegmentGroup);

        SegmentGroup GetSegmentGroupById(int id);
    }
}
