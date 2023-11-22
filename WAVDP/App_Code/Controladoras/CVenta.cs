using SWLNVDP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CVenta
/// </summary>
public class CVenta
{
    #region Atributos
    private LNServicio lNServicio;
    #endregion
    #region Propiedades

    public string NombreClase
    {
        get { return GetType().Name; }
    }

    #endregion
    #region Constructor
    public CVenta()
    {
        lNServicio = new LNServicio();
    }
    #endregion
    #region Metodos Públicos
    #region CVenta
    public void Insertar_VVenta_I(string CodigoVenta, string MetodoPagoVenta, string TipoEntregaVenta, int CantidadProductoVenta, decimal PrecioTotalVenta, string CodigoCliente, string CodigoProducto, string CodigoEmpleado)
    {
        try
        {
            lNServicio.Insertar_VVenta_I(CodigoVenta, MetodoPagoVenta, TipoEntregaVenta, CantidadProductoVenta, PrecioTotalVenta, CodigoCliente, CodigoProducto, CodigoEmpleado);

        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVVenta> Obtener_VVenta_O_Todo()
    {
        List<EVVenta> lstVenta = new List<EVVenta>();
        try
        {
            lstVenta = lNServicio.Obtener_VVenta_O_Todo();
        }
        catch (Exception)
        {
            throw;
        }
        return lstVenta;
    }
    public EVVenta Obtener_VVenta_O_CodigoVenta(string CodigoVenta)
    {
        EVVenta eVVenta = new EVVenta();
        try
        {
            eVVenta = lNServicio.Obtener_VVenta_O_CodigoVenta(CodigoVenta);
        }
        catch (Exception)
        {
            throw;
        }
        return eVVenta;
    }
    public void Eliminar_VVenta_E(string CodigoVenta)
    {
        try
        {
            lNServicio.Eliminar_VVenta_E(CodigoVenta);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #endregion
}