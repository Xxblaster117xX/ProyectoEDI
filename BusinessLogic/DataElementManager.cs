using BusinessLogic.Definition;
using Entities.Entidades_Definicion;

public class DataElementManager : IDataElementManager
{
    /// <summary>
    /// Lista de data Elements
    /// </summary>
    public List<DataElement> dataElements = new List<DataElement>();


    /// <summary>
    /// Método para validar un DataElement.
    /// </summary>
    /// <param name="dataElement"></param>
    /// <param name="errorMessage"></param>
    /// <returns></returns>
    private bool ValidateDataElement(DataElement dataElement, out string errorMessage)
    {
        errorMessage = string.Empty;

        if (string.IsNullOrWhiteSpace(dataElement.Name))
        {
            errorMessage = "El nombre del DataElement es obligatorio.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(dataElement.Description))
        {
            errorMessage = "La descripción del DataElement es obligatoria.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(dataElement.ValueFormat))
        {
            errorMessage = "El formato del DataElement es obligatorio.";
            return false;
        }

        // Verificar que no exista un DataElement con el mismo nombre (o código, dependiendo de lo que se desee validar)
        if (dataElements.Any(de => de.Name == dataElement.Name && de.Code != dataElement.Code))
        {
            errorMessage = "Ya existe un DataElement con ese nombre.";
            return false;
        }

        return true;
    }

    /// <summary>
    /// Método para agregar un nuevo DataElement a la lista.
    /// </summary>
    /// <param name="dataElement"></param>
    /// <returns></returns>
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

    /// <summary>
    /// Método para eliminar un DataElement por su código.
    /// </summary>
    /// <param name="code"></param>
    /// <returns></returns>
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

    /// <summary>
    /// Método para actualizar un DataElement existente.
    /// </summary>
    /// <param name="updatedDataElement"></param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
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
        existingDataElement.Name = updatedDataElement.Name;
        existingDataElement.Description = updatedDataElement.Description;
        existingDataElement.ValueFormat = updatedDataElement.ValueFormat;

        Console.WriteLine($"Elemento de dato con ID {updatedDataElement.Id} actualizado correctamente.");
    }


    /// <summary>
    /// Método para obtener la lista de data elements
    /// </summary>
    /// <returns></returns>
    public List<DataElement> GetAllDataElements()
    {
        return dataElements;
    }

    /// <summary>
    /// Obtener un data element según su código.
    /// </summary>
    /// <param name="code"></param>
    /// <returns></returns>
    public DataElement GetDataElementByCode(int code)
    {
        return dataElements.FirstOrDefault(de => de.Code == code);
    }
}
