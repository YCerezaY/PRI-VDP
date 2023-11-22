using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EVVentaCompleja
/// </summary>
public class EVVentaCompleja
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
    public string NombreCompletoCliente { get; set; }
    [DataMember]
    public string CodigoProducto { get; set; }
    [DataMember]
    public string NombreProducto { get; set; }
    #endregion

    #region “Auditoría básica”
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    #endregion
    [DataMember]
    public string CodigoEmpleado { get; set; }
    [DataMember]
    public string NombreCompletoEmpleado { get; set; }

    public string ApellidoPaternoEmpleado { get; set; }
    public string ApellidoPaternoCliente { get; set; }

    #region Constructores
    public EVVentaCompleja()
    {
        CodigoVenta = string.Empty;
        MetodoPagoVenta = string.Empty;
        TipoEntregaVenta = string.Empty;
        CantidadProductoVenta = int.MinValue;
        PrecioTotalVenta = decimal.MinValue;
        CodigoCliente = string.Empty;
        NombreCompletoCliente = string.Empty;
        CodigoProducto = string.Empty;
        NombreProducto = string.Empty;
        FechaRegistro = DateTime.MinValue;
        CodigoEmpleado = string.Empty;
        NombreCompletoEmpleado = string.Empty;
    }
    //public EVVentaCompleja()
    //{
    //    CodigoVenta = string.Empty;
    //    MetodoPagoVenta = string.Empty;
    //    TipoEntregaVenta = string.Empty;
    //    CantidadProductoVenta = int.MinValue;
    //    PrecioTotalVenta = decimal.MinValue;
    //    CodigoCliente = string.Empty;
    //    NombreCompletoCliente = string.Empty;
    //    CodigoProducto = string.Empty;
    //    NombreProducto = string.Empty;
    //    FechaRegistro = DateTime.MinValue;
    //    CodigoEmpleado = string.Empty;
    //    NombreCompletoEmpleado = string.Empty;
    //    ApellidoPaternoCliente = string.Empty;
    //    ApellidoPaternoEmpleado = string.Empty;
    //}
    #endregion
}