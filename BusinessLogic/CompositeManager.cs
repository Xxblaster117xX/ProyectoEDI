using BusinessLogic.Interfaz;
using Entities.Entidades_Definicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CompositeManager: ICompositeManager
    {
        private List<CompositeDataElement> _compositeList = new List<CompositeDataElement>();

        public bool ValidateComposite(CompositeDataElement composite)
        {
            if (string.IsNullOrWhiteSpace(composite.Name))
            {

                return false;
            }

            if (string.IsNullOrWhiteSpace(composite.Description))
            {

                return false;
            }

            if (string.IsNullOrWhiteSpace(composite.Code))
            {

                return false;
            }



            return true;
        }

        // Método de validación

        public void AddComposite(CompositeDataElement composite)
        {

            _compositeList.Add(composite);
        }
        public List<CompositeDataElement> GetAll()
        {
            return _compositeList;
        }

        public CompositeDataElement GetCompositeById(int id)
        {
            return _compositeList.FirstOrDefault(composite => composite.Id == id);
        }

        public string UpdateComposite(CompositeDataElement composite)
        {
            string errorMessage;
            if (ValidateComposite(composite))
            {
                var existingElement = GetCompositeById(composite.Id);
                if (existingElement != null)
                {
                    existingElement.Name = composite.Name;
                    existingElement.Description = composite.Description;
                    existingElement.Code = composite.Code;

                    errorMessage= "El elemento de dato compuesto ha sido actualizado exitosamente.";
                }
                else
                {
                    errorMessage =  "El elemento de dato compuesto a actualizar no existe.";
                }
            }
            else
            {
                errorMessage = "El elemento de dato compuesto no es valido.";
            }
            return errorMessage;
        }

       
    }
    
}
