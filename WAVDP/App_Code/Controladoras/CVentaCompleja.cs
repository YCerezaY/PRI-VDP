using SWLNVDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CVentaCompleja
/// </summary>
public class CVentaCompleja
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

    public CVentaCompleja()
    {
        lNServicio = new LNServicio();
    }

    #endregion

    #region Metodos Publicos

    #region EVVentaCompleja
    public List<EVVentaCompleja> Obtener_VVenta_O_Compleja()
    {
        List<EVVentaCompleja> lstVentaCompleja = new List<EVVentaCompleja>();
        try
        {
            lstVentaCompleja = lNServicio.Obtener_VVenta_O_Compleja();
        }
        catch (Exception)
        {
            throw;
        }
        return lstVentaCompleja;
    }

    public List<EVVentaCompleja> Obtener_VVenta_O_Compleja_CodigoCliente(string CodigoCliente)
    {
        List<EVVentaCompleja> lstVentaCompleja = new List<EVVentaCompleja>();
        try
        {
            lstVentaCompleja = lNServicio.Obtener_VVenta_O_Compleja_CodigoCliente(CodigoCliente);
        }
        catch (Exception)
        {
            throw;
        }
        return lstVentaCompleja;
    }

    public List<EVVentaCompleja> Obtener_VVenta_O_Compleja_CodigoEmpleado(string CodigoEmpleado)
    {
        List<EVVentaCompleja> lstVentaCompleja = new List<EVVentaCompleja>();
        try
        {
            lstVentaCompleja = lNServicio.Obtener_VVenta_O_Compleja_CodigoEmpleado(CodigoEmpleado);
        }
        catch (Exception)
        {
            throw;
        }
        return lstVentaCompleja;
    }

    public List<EVVentaCompleja> Obtener_VVenta_O_Compleja_CodigoProducto(string CodigoProducto)
    {
        List<EVVentaCompleja> lstVentaCompleja = new List<EVVentaCompleja>();
        try
        {
            lstVentaCompleja = lNServicio.Obtener_VVenta_O_Compleja_CodigoProducto(CodigoProducto);
        }
        catch (Exception)
        {
            throw;
        }
        return lstVentaCompleja;
    }

    #endregion

    #endregion
}