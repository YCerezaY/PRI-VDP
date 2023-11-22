using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CVVenta
/// </summary>
public class CVVenta
{
    #region Atributos
    private ADVVenta aDVVenta;
    #endregion

    #region Constructor
    public CVVenta()
    {
        aDVVenta = new ADVVenta();
    }
    #endregion

    #region Métodos públicos
    public void Insertar_VVenta_I(EVVenta eVVenta)
    {
        aDVVenta.Insertar_VVenta_I(eVVenta);
    }
    public List<EVVenta> Obtener_VVenta_O_Todo()
    {
        EVVenta eVVenta;
        List<EVVenta> lstVenta = new List<EVVenta>();
        DTOVDPVenta dTOVDPVenta = aDVVenta.Obtener_VVenta_O_Todo();
        foreach (DTOVDPVenta.VVentaRow drVVenta in dTOVDPVenta.VVenta.Rows)
        {
            eVVenta = new EVVenta();
            eVVenta.CodigoVenta = drVVenta.CodigoVenta;
            eVVenta.MetodoPagoVenta = drVVenta.MetodoPagoVenta;
            eVVenta.TipoEntregaVenta = drVVenta.TipoEntregaVenta;
            eVVenta.CantidadProductoVenta = drVVenta.CantidadProductoVenta;
            eVVenta.PrecioTotalVenta = drVVenta.PrecioTotalVenta;
            eVVenta.CodigoCliente = drVVenta.CodigoCliente;
            eVVenta.CodigoProducto = drVVenta.CodigoProducto;
            eVVenta.FechaRegistro = drVVenta.FechaRegistro;
            eVVenta.CodigoEmpleado = drVVenta.CodigoEmpleado;
            lstVenta.Add(eVVenta);
        }

        return lstVenta;
    }
    public EVVenta Obtener_VVenta_O_CodigoVenta(string CodigoVenta)
    {
        EVVenta eVVenta = new EVVenta();
        DTOVDPVenta dTOVDPVenta = aDVVenta.Obtener_VVenta_O_CodigoVenta(CodigoVenta);
        foreach (DTOVDPVenta.VVentaRow drVVenta in dTOVDPVenta.VVenta.Rows)
        {
            eVVenta = new EVVenta();
            eVVenta.CodigoVenta = drVVenta.CodigoVenta;
            eVVenta.MetodoPagoVenta = drVVenta.MetodoPagoVenta;
            eVVenta.TipoEntregaVenta = drVVenta.TipoEntregaVenta;
            eVVenta.CantidadProductoVenta = drVVenta.CantidadProductoVenta;
            eVVenta.PrecioTotalVenta = drVVenta.PrecioTotalVenta;
            eVVenta.CodigoCliente = drVVenta.CodigoCliente;
            eVVenta.CodigoProducto = drVVenta.CodigoProducto;
            eVVenta.FechaRegistro = drVVenta.FechaRegistro;
            eVVenta.CodigoEmpleado = drVVenta.CodigoEmpleado;
        }
        return eVVenta;
    }
    public List<EVVenta> Obtener_VVenta_O_CodigoCliente(string CodigoCliente)
    {
        EVVenta eVVenta;
        List<EVVenta> lstVenta = new List<EVVenta>();
        DTOVDPVenta dTOVDPVenta = aDVVenta.Obtener_VVenta_O_CodigoCliente(CodigoCliente);
        foreach (DTOVDPVenta.VVentaRow drVVenta in dTOVDPVenta.VVenta.Rows)
        {
            eVVenta = new EVVenta();
            eVVenta.CodigoVenta = drVVenta.CodigoVenta;
            eVVenta.MetodoPagoVenta = drVVenta.MetodoPagoVenta;
            eVVenta.TipoEntregaVenta = drVVenta.TipoEntregaVenta;
            eVVenta.CantidadProductoVenta = drVVenta.CantidadProductoVenta;
            eVVenta.PrecioTotalVenta = drVVenta.PrecioTotalVenta;
            eVVenta.CodigoCliente = drVVenta.CodigoCliente;
            eVVenta.CodigoProducto = drVVenta.CodigoProducto;
            eVVenta.FechaRegistro = drVVenta.FechaRegistro;
            eVVenta.CodigoEmpleado = drVVenta.CodigoEmpleado;
            lstVenta.Add(eVVenta);
        }

        return lstVenta;
    }

    public List<EVVenta> Obtener_VVenta_O_CodigoEmpleado(string CodigoEmpleado)
    {
        EVVenta eVVenta;
        List<EVVenta> lstVenta = new List<EVVenta>();
        DTOVDPVenta dTOVDPVenta = aDVVenta.Obtener_VVenta_O_CodigoEmpleado(CodigoEmpleado);
        foreach (DTOVDPVenta.VVentaRow drVVenta in dTOVDPVenta.VVenta.Rows)
        {
            eVVenta = new EVVenta();
            eVVenta.CodigoVenta = drVVenta.CodigoVenta;
            eVVenta.MetodoPagoVenta = drVVenta.MetodoPagoVenta;
            eVVenta.TipoEntregaVenta = drVVenta.TipoEntregaVenta;
            eVVenta.CantidadProductoVenta = drVVenta.CantidadProductoVenta;
            eVVenta.PrecioTotalVenta = drVVenta.PrecioTotalVenta;
            eVVenta.CodigoCliente = drVVenta.CodigoCliente;
            eVVenta.CodigoProducto = drVVenta.CodigoProducto;
            eVVenta.FechaRegistro = drVVenta.FechaRegistro;
            eVVenta.CodigoEmpleado = drVVenta.CodigoEmpleado;
            lstVenta.Add(eVVenta);
        }

        return lstVenta;
    }

    public List<EVVenta> Obtener_VVenta_O_CodigoProducto(string CodigoProducto)
    {
        EVVenta eVVenta;
        List<EVVenta> lstVenta = new List<EVVenta>();
        DTOVDPVenta dTOVDPVenta = aDVVenta.Obtener_VVenta_O_CodigoProducto(CodigoProducto);
        foreach (DTOVDPVenta.VVentaRow drVVenta in dTOVDPVenta.VVenta.Rows)
        {
            eVVenta = new EVVenta();
            eVVenta.CodigoVenta = drVVenta.CodigoVenta;
            eVVenta.MetodoPagoVenta = drVVenta.MetodoPagoVenta;
            eVVenta.TipoEntregaVenta = drVVenta.TipoEntregaVenta;
            eVVenta.CantidadProductoVenta = drVVenta.CantidadProductoVenta;
            eVVenta.PrecioTotalVenta = drVVenta.PrecioTotalVenta;
            eVVenta.CodigoCliente = drVVenta.CodigoCliente;
            eVVenta.CodigoProducto = drVVenta.CodigoProducto;
            eVVenta.FechaRegistro = drVVenta.FechaRegistro;
            eVVenta.CodigoEmpleado = drVVenta.CodigoEmpleado;
            lstVenta.Add(eVVenta);
        }

        return lstVenta;
    }
    public void Eliminar_VVenta_E(string CodigoVenta)
    {
        aDVVenta.Eliminar_VVenta_E(CodigoVenta);
    }
    #endregion
}