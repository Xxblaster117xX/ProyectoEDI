using Entities.Entidades_Definicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaz
{
    public interface ICompositeManager
    {
        bool ValidateComposite(CompositeDataElement composite);
        void AddComposite(CompositeDataElement composite);
       
        List<CompositeDataElement> GetAll();

        string UpdateComposite(CompositeDataElement composite);

        CompositeDataElement GetCompositeById(int id);
    }
}
