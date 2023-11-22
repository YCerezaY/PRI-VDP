using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Web;
using System.IdentityModel.Policy;

/// <summary>
/// Descripción breve de ADVVenta
/// </summary>
public class ADVVenta
{
    #region Metodos Publicos
    public void Insertar_VVenta_I(EVVenta eVVenta)
    {
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VVenta_I");
            BDSWADNETVDP.AddInParameter(dbCommand, "CodigoVenta", DbType.String, eVVenta.CodigoVenta);
            BDSWADNETVDP.AddInParameter(dbCommand, "MetodoPagoVenta", DbType.String, eVVenta.MetodoPagoVenta);
            BDSWADNETVDP.AddInParameter(dbCommand, "TipoEntregaVenta", DbType.String, eVVenta.TipoEntregaVenta);
            BDSWADNETVDP.AddInParameter(dbCommand, "CantidadProductoVenta", DbType.Int32, eVVenta.CantidadProductoVenta);
            BDSWADNETVDP.AddInParameter(dbCommand, "PrecioTotalVenta", DbType.Decimal, eVVenta.PrecioTotalVenta);
            BDSWADNETVDP.AddInParameter(dbCommand, "CodigoCliente", DbType.String, eVVenta.CodigoCliente);
            BDSWADNETVDP.AddInParameter(dbCommand, "CodigoProducto", DbType.String, eVVenta.CodigoProducto);
            BDSWADNETVDP.AddInParameter(dbCommand, "Estado", DbType.Int32, EPAEstaticos.EstadoActiva);
            BDSWADNETVDP.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, EPAEstaticos.FechaRegistro);
            BDSWADNETVDP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, EPAEstaticos.FechaModificacion);
            BDSWADNETVDP.AddInParameter(dbCommand, "CodigoEmpleado", DbType.String, eVVenta.CodigoEmpleado);
            BDSWADNETVDP.ExecuteNonQuery(dbCommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DTOVDPVenta Obtener_VVenta_O_Todo()
    {
        DTOVDPVenta dTOVDPVenta = new DTOVDPVenta();
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VVenta_O");
            BDSWADNETVDP.AddInParameter(dbCommand, "Estado", DbType.Int32, EPAEstaticos.EstadoActiva);
            BDSWADNETVDP.LoadDataSet(dbCommand, dTOVDPVenta, "VVenta");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dTOVDPVenta;
    }
    public DTOVDPVenta Obtener_VVenta_O_CodigoVenta(string CodigoVenta)
    {
        DTOVDPVenta dTOVDPVenta = new DTOVDPVenta();
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VVenta_O_CodigoVenta");
            BDSWADNETVDP.AddInParameter(dbCommand, "CodigoVenta", DbType.String, CodigoVenta);
            BDSWADNETVDP.AddInParameter(dbCommand, "Estado", DbType.Int32, EPAEstaticos.EstadoActiva);
            BDSWADNETVDP.LoadDataSet(dbCommand, dTOVDPVenta, "VVenta");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dTOVDPVenta;
    }
    public DTOVDPVenta Obtener_VVenta_O_CodigoCliente(string _CodigoCliente)
    {
        DTOVDPVenta dTOVDPVenta = new DTOVDPVenta();
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VVenta_O_CodigoCliente");
            BDSWADNETVDP.AddInParameter(dbCommand, "CodigoCliente", DbType.String, _CodigoCliente);
            BDSWADNETVDP.AddInParameter(dbCommand, "Estado", DbType.Int32, EPAEstaticos.EstadoActiva);
            BDSWADNETVDP.LoadDataSet(dbCommand, dTOVDPVenta, "VVenta");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dTOVDPVenta;
    }
    public DTOVDPVenta Obtener_VVenta_O_CodigoEmpleado(string CodigoEmpleado)
    {
        DTOVDPVenta dTOVDPVenta = new DTOVDPVenta();
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VVenta_O_CodigoEmpleado");
            BDSWADNETVDP.AddInParameter(dbCommand, "CodigoEmpleado", DbType.String, CodigoEmpleado);
            BDSWADNETVDP.AddInParameter(dbCommand, "Estado", DbType.Int32, EPAEstaticos.EstadoActiva);
            BDSWADNETVDP.LoadDataSet(dbCommand, dTOVDPVenta, "VVenta");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dTOVDPVenta;
    }
    public DTOVDPVenta Obtener_VVenta_O_CodigoProducto(string CodigoProducto)
    {
        DTOVDPVenta dTOVDPVenta = new DTOVDPVenta();
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VVenta_O_CodigoProducto");
            BDSWADNETVDP.AddInParameter(dbCommand, "CodigoProducto", DbType.String, CodigoProducto);
            BDSWADNETVDP.AddInParameter(dbCommand, "Estado", DbType.Int32, EPAEstaticos.EstadoActiva);
            BDSWADNETVDP.LoadDataSet(dbCommand, dTOVDPVenta, "VVenta");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dTOVDPVenta;
    }
    public void Eliminar_VVenta_E(string CodigoVenta)
    {
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VVenta_E");
            BDSWADNETVDP.AddInParameter(dbCommand, "CodigoVenta", DbType.String, CodigoVenta);
            BDSWADNETVDP.AddInParameter(dbCommand, "Estado", DbType.Int32, EPAEstaticos.EstadoInactivo);
            BDSWADNETVDP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, EPAEstaticos.FechaModificacion);
            BDSWADNETVDP.ExecuteNonQuery(dbCommand);

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion
}