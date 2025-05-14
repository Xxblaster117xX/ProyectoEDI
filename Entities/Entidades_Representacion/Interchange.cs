using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades_Representacion.Abstract;


namespace Entities.Entidades_Representacion
{

    /// <summary>
    /// Clase que representa un Intercambio de mensajes
    /// </summary>
    public class Interchange
    {
        /// <summary>
        /// Fecha de creación del intercambio
        /// </summary>
        public string CreationDate { get; set; }
        /// <summary>
        /// El que envía el mensaje
        /// </summary>
        public string Sender { get; set; }
        /// <summary>
        /// El que recibe el mensaje
        /// </summary>
        public string Recipient { get; set; }
        /// <summary>
        /// Listado de  documentos que contiene el intercambio
        /// </summary>
        public List<Document> Documents { get; set; }
    }
}
