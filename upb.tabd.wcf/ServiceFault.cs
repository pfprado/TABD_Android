using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace upb.tabd.wcf
{
    /// <summary>
    /// Permite mapear una excepción capturada en la capa de servicios wcf. Es usada
    /// por una aplicación cliente para capturar el detalle del error.
    /// </summary>
    [DataContract(Namespace = "http://upb.tabd.wcf.org")]
    public class ServiceFault
    {
        #region Constructores

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public ServiceFault()
        {
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Identificación generada de la excepcion.
        /// </summary>
        [DataMember]
        public Guid Id
        {
            get;
            set;
        }

        /// <summary>
        /// Mensaje de error que explica la razón de la excepción.
        /// </summary>
        [DataMember]
        public string MessageText
        {
            get;
            set;
        }

        #endregion
    }
}