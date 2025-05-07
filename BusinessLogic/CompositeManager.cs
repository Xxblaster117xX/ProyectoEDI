using BusinessLogic.Interfaz;
using Entities.Entidades_Definicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CompositeManager : ICompositeManager
    {
        private List<CompositeDataElement> _compositeList = new List<CompositeDataElement>();

        private int contador = 0;

        public int AutoIncrementId()
        {
            return ++contador;
        }

        /// <summary>
        /// Este método es para validar que no se introducen campos vacios al composite.
        /// </summary>
        /// <param name="composite"></param>
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

        /// <summary>
        /// Este método agrega un composite a la lista de composite.
        /// </summary>
        /// <param name="composite"></param>

        public void AddComposite(CompositeDataElement composite)
        {

            _compositeList.Add(composite);
        }

        /// <summary>
        /// Este método obtiene un todos los composite de la lista.
        /// </summary>
        ///
        public List<CompositeDataElement> GetAll()
        {
            return _compositeList;
        }

        /// <summary>
        /// Este método obtiene un composite por id .
        /// </summary>
        ///
        public CompositeDataElement GetCompositeById(int id)
        {
            return _compositeList.FirstOrDefault(composite => composite.Id == id);
        }

        /// <summary>
        /// Este método actualiza un composite .
        /// </summary>
        ///
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

                    errorMessage = "El elemento de dato compuesto ha sido actualizado exitosamente.";
                }
                else
                {
                    errorMessage = "El elemento de dato compuesto a actualizar no existe.";
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

 

    
