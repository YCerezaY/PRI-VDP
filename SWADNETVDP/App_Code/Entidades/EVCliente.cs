using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EVCLiente
/// </summary>
public class EVCliente
{
    #region Propiedades
    [DataMember]
    public string CodigoCliente { get; set; }
    [DataMember]
    public string NombreCliente { get; set; }
    [DataMember]
    public string ApellidoPaternoCliente { get; set; }
    [DataMember]
    public string ApellidoMaternoCliente { get; set; }
    [DataMember]
    public string DireccionCliente { get; set; }
    [DataMember]
    public int TelefonoCliente { get; set; }
    #endregion

    #region “Auditoría básica”
    [DataMember]
    public int Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaModificacion { get; set; }
    #endregion

    #region Constructores
    public EVCliente()
    {
        CodigoCliente = string.Empty;
        NombreCliente = string.Empty;
        ApellidoPaternoCliente = string.Empty;
        ApellidoMaternoCliente = string.Empty;
        DireccionCliente = string.Empty;
        TelefonoCliente = int.MinValue;
        Estado = int.MinValue;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
    #endregion
}