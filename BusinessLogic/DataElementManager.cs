using BusinessLogic.Definition;
using Entities.Entidades_Definicion;

public class DataElementManager : IDataElementManager
{
    private List<DataElement> dataElements = new List<DataElement>
    {
        new DataElement
        {
            Code = 1,
            DataElementName = "Elemento A",
            DataElementDescription = "Descripción del Elemento A",
            DataElementValueFormat = "Formato A",
            CodeLists = new List<CodeList>()
        },
        new DataElement
        {
            Code = 2,
            DataElementName = "Elemento B",
            DataElementDescription = "Descripción del Elemento B",
            DataElementValueFormat = "Formato B",
            CodeLists = new List<CodeList>()
        }
    };

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

        if (string.IsNullOrWhiteSpace(dataElement.DataElementValueFormat))
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
            // Generar un código único para el nuevo DataElement
            int newCode = dataElements.Max(de => de.DataElementId) + 1; // Obtiene el máximo código y le suma 1
            dataElement.Code = newCode;

            // Agregar el DataElement a la lista
            dataElements.Add(dataElement);
            return "DataElement agregado exitosamente.";
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
            return "DataElement eliminado exitosamente.";
        }
        else
        {
            return "No se encontró el DataElement con el código proporcionado.";
        }
    }

    // Actualizar un DataElement
    public string UpdateDataElement(DataElement dataElement)
    {
        string errorMessage;
        if (ValidateDataElement(dataElement, out errorMessage))
        {
            var existingElement = GetDataElementByCode(dataElement.DataElementId);
            if (existingElement != null)
            {
                existingElement.DataElementName = dataElement.DataElementName;
                existingElement.DataElementDescription = dataElement.DataElementDescription;
                existingElement.DataElementValueFormat = dataElement.DataElementValueFormat;
                existingElement.CodeLists = dataElement.CodeLists;

                return "DataElement actualizado exitosamente.";
            }
            else
            {
                return "El DataElement a actualizar no existe.";
            }
        }
        else
        {
            return errorMessage;
        }
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
