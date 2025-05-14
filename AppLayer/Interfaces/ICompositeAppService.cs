using Entities.Entidades_Definicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLayer.Interfaces
{
    public interface ICompositeAppService
    {
        void AddComposite(CompositeDataElement composite);

        List<CompositeDataElement> GetAll();

        void UpdateComposite(CompositeDataElement composite);

        CompositeDataElement GetCompositeById(int id);
    }
}
