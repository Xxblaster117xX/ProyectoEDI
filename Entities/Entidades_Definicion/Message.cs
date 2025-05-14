using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities.Model.Enum;

namespace Entities.Entidades_Definicion
{
    /// <summary>
    /// Clase que representa un mensaje en el sistema.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Id de la definición del mensaje en la base de datos
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Enum para seleccionar el tipo de documento
        /// </summary>
        [Required]
        
        public MessageTypeEnum MessageType { get; set; }

        /// <summary>
        /// Versión del mensaje(D, S, 90, 89, etc...)
        /// </summary>
        public string? Version { get; set; }
        /// <summary>
        /// Año y parte del año en el que se lanzó la versión(Ej: 96A)
        /// </summary>
        public string? Release { get; set; }
        /// <summary>
        /// Tipo de Directory(ej: UN)
        /// </summary>
        public string? Directory { get; set; }
        /// <summary>
        /// Ejemplo: EAN005
        /// </summary>
        public string? DirectoryVersion { get; set; }
        /// <summary>
        /// Nombre del mensaje
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Descripción del mensaje
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Lista de posiciones que contiene el mensaje
        /// </summary>
        [NotMapped]
        public List<MessagePosition> MessagePositions { get; set; }
       
    }
}
