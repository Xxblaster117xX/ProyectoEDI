using System.Collections.Generic;
using Entities.Entidades_Definicion;

namespace BusinessLogic.Definition
{
    public interface IDataElementManager
    {
        // Obtener todos los DataElements
        List<DataElement> GetAllDataElements();

        // Obtener un DataElement por su código
        DataElement GetDataElementByCode(int id);

        // Agregar un nuevo DataElement
        string AddDataElement(DataElement dataElement);

        // Eliminar un DataElement por su código
        string DeleteDataElement(int id);

        // Actualizar un DataElement existente
        string UpdateDataElement(DataElement dataElement);
    }
}
