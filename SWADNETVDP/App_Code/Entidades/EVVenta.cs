using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EVenta
/// </summary>
public class EVVenta
{
    #region Propiedades
    [DataMember]
    public string CodigoVenta { get; set; }
    [DataMember]
    public string MetodoPagoVenta { get; set; }
    [DataMember]
    public string TipoEntregaVenta { get; set; }
    [DataMember]
    public int CantidadProductoVenta { get; set; }
    [DataMember]
    public decimal PrecioTotalVenta { get; set; }
    [DataMember]
    public string CodigoCliente { get; set; }
    [DataMember]
    public string CodigoProducto { get; set; }
    #endregion

    #region “Auditoría básica”
    [DataMember]
    public int Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaModificacion { get; set; }
    #endregion
    public string CodigoEmpleado { get; set; }

    #region Constructores
    public EVVenta()
    {
        CodigoVenta = string.Empty;
        MetodoPagoVenta = string.Empty;
        TipoEntregaVenta = string.Empty;
        CantidadProductoVenta = int.MinValue;
        PrecioTotalVenta = decimal.MinValue;
        CodigoCliente = string.Empty;
        CodigoProducto = string.Empty;
        Estado = int.MinValue;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
        CodigoEmpleado = string.Empty;
    }
    #endregion
}