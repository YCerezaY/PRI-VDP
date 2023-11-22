using System;
using System.Collections.Generic;
//using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EVProducto
/// </summary>
public class EVProducto
{
    #region Propiedades
    [DataMember]
    public string CodigoProducto { get; set; }
    [DataMember]
    public string NombreProducto { get; set; }
    [DataMember]
    public string DescripcionProducto { get; set; }
    [DataMember]
    public decimal PrecioUnitarioProducto { get; set; }
    [DataMember]
    public int StockProducto { get; set; }
    #region “Auditoría básica”
    [DataMember]
    public string EstadoProducto { get; set; }
    [DataMember]
    public DateTime FechaRegistroProducto { get; set; }
    [DataMember]
    public DateTime FechaModificacionProducto { get; set; }
    #endregion
    #endregion

    #region Constructores


    public EVProducto()
    {
        CodigoProducto = string.Empty;
        NombreProducto = string.Empty;
        DescripcionProducto = string.Empty;
        PrecioUnitarioProducto = decimal.MinValue;
        StockProducto = int.MinValue;
        EstadoProducto = string.Empty;
        FechaRegistroProducto = DateTime.MinValue;
        FechaModificacionProducto = DateTime.MinValue;
    }
    #endregion
}