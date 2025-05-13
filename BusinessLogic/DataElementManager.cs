using BusinessLogic.Definition;
using Entities.Entidades_Definicion;

public class DataElementManager : IDataElementManager
{
    /// <summary>
    /// Dos elementos añadidos para revisar la visualización
    /// </summary>
    public List<DataElement> dataElements = new List<DataElement>();


    // Método de validación
    private bool ValidateDataElement(DataElement dataElement, out string errorMessage)
    {
        errorMessage = string.Empty;

        if (string.IsNullOrWhiteSpace(dataElement.DataElementName))
        {
            errorMessage = "El nombre del DataElement es obligatorio.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(dataElement.DataElementDescription))
        {
            errorMessage = "La descripción del DataElement es obligatoria.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(dataElement.Format))
        {
            errorMessage = "El formato del DataElement es obligatorio.";
            return false;
        }

        // Verificar que no exista un DataElement con el mismo nombre (o código, dependiendo de lo que se desee validar)
        if (dataElements.Any(de => de.DataElementName == dataElement.DataElementName && de.Code != dataElement.Code))
        {
            errorMessage = "Ya existe un DataElement con ese nombre.";
            return false;
        }

        return true;
    }

    // Agregar un nuevo DataElement
    public string AddDataElement(DataElement dataElement)
    {
        string errorMessage;
        if (ValidateDataElement(dataElement, out errorMessage))
        { 

            // Agregar el DataElement a la lista
            dataElements.Add(dataElement);
            return "Elemento de dato agregado exitosamente.";
        }
        else
        {
            return errorMessage;
        }
    }

    // Eliminar un DataElement
    public string DeleteDataElement(int code)
    {
        var dataElement = GetDataElementByCode(code);
        if (dataElement != null)
        {
            dataElements.Remove(dataElement);
            return "Elemento de dato eliminado exitosamente.";
        }
        else
        {
            return "No se encontró el elemento de dato con el código proporcionado.";
        }
    }

    // Actualizar un DataElement
    public void UpdateDataElement(DataElement updatedDataElement)
    {
        if (updatedDataElement == null)
        {
            throw new ArgumentNullException(nameof(updatedDataElement), "El elemento de dato no puede ser nulo.");
        }

        // Buscar el elemento de dato existente por su ID
        var existingDataElement = GetAllDataElements().FirstOrDefault(de => de.Id == updatedDataElement.Id);

        if (existingDataElement == null)
        {
            throw new InvalidOperationException($"No se encontró un elemento de dato con el ID {updatedDataElement.Id}.");
        }
        // Actualizar los campos del elemento de dato existente
        existingDataElement.DataElementName = updatedDataElement.DataElementName;
        existingDataElement.DataElementDescription = updatedDataElement.DataElementDescription;
        existingDataElement.Format = updatedDataElement.Format;

        Console.WriteLine($"Elemento de dato con ID {updatedDataElement.Id} actualizado correctamente.");
    }


    // Obtener todos los DataElements
    public List<DataElement> GetAllDataElements()
    {
        return dataElements;
    }

    // Obtener un DataElement por su código
    public DataElement GetDataElementByCode(int code)
    {
        return dataElements.FirstOrDefault(de => de.Code == code);
    }
}
