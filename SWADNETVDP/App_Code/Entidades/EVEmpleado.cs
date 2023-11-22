using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EVEmpleado
/// </summary>
public class EVEmpleado
{
    #region Propiedades
    [DataMember]
    public string CodigoEmpleado { get; set; }
    [DataMember]
    public string NombreEmpleado { get; set; }
    [DataMember]
    public string ApellidoPaternoEmpleado { get; set; }
    [DataMember]
    public string ApellidoMaternoEmpleado { get; set; }
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
    public EVEmpleado()
    {
        CodigoEmpleado = string.Empty;
        NombreEmpleado = string.Empty;
        ApellidoPaternoEmpleado = string.Empty;
        ApellidoMaternoEmpleado = string.Empty;
        Estado = int.MinValue;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
    #endregion
}