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
        /// Este método es para validar un composite.
        /// </summary>
        /// <param name="composite"></param>
       

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
        public void UpdateComposite(CompositeDataElement composite)
        {
            string errorMessage;
           
                var existingElement = GetCompositeById(composite.Id);
                if (existingElement != null)
                {
                    existingElement.Name = composite.Name;
                    existingElement.Description = composite.Description;
                    existingElement.Code = composite.Code;

                    
                }
 
        }

    }
}

 

    
