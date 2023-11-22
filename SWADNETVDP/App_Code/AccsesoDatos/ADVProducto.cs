using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;
using System.ServiceModel;
/// <summary>
/// Descripción breve de ADVProducto
/// </summary>
public class ADVProducto
{
    #region Metodos Privados
    /// <summary>
    /// Contruir el Error del servicio > metodo
    /// </summary>
    /// <param name="tipoError"></param>
    /// <param name="metodo"></param>
    /// <param name="excepcion"></param>
    /// <param name="mensaje"></param>
    /// <returns></returns>
    private EDefectoAD ContruirErrorServicio(TTipoError tipoError, string metodo, string excepcion, string mensaje)
    {
        EDefectoAD eDefectoAD = new EDefectoAD();
        eDefectoAD.TipoError = tipoError;
        eDefectoAD.Servicio = "SWADNETVDP";
        eDefectoAD.Clase = "ADVProducto";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }
    #endregion
    #region Metodos públicos

    public void Insertar_VProducto_I(EVProducto eVProducto)
    {
        try
        {
            Database BDSWADVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADVDP.GetStoredProcCommand("VProducto_I");
            BDSWADVDP.AddInParameter(dbCommand, "CodigoProducto", DbType.String, eVProducto.CodigoProducto);
            BDSWADVDP.AddInParameter(dbCommand, "NombreProducto", DbType.String, eVProducto.NombreProducto);
            BDSWADVDP.AddInParameter(dbCommand, "DescripcionProducto", DbType.String, eVProducto.DescripcionProducto);
            BDSWADVDP.AddInParameter(dbCommand, "PrecioUnitarioProducto", DbType.Decimal, eVProducto.PrecioUnitarioProducto);
            BDSWADVDP.AddInParameter(dbCommand, "StockProducto", DbType.Int32, eVProducto.StockProducto);
            BDSWADVDP.AddInParameter(dbCommand, "EstadoProducto", DbType.Int32, EPAEstaticos.EstadoActiva);
            BDSWADVDP.AddInParameter(dbCommand, "FechaRegistroProducto", DbType.DateTime, EPAEstaticos.FechaRegistro);
            BDSWADVDP.AddInParameter(dbCommand, "FechaModificacionProducto", DbType.DateTime, EPAEstaticos.FechaModificacion);
            BDSWADVDP.ExecuteNonQuery(dbCommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DTOVDProducto Obtener_VProducto_O_Todo()
    {
        DTOVDProducto dTOVDProducto = new DTOVDProducto();
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VProducto_O");
            BDSWADNETVDP.AddInParameter(dbCommand, "EstadoProducto", DbType.Int32, EPAEstaticos.EstadoActiva);
            BDSWADNETVDP.LoadDataSet(dbCommand, dTOVDProducto, "VProducto");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dTOVDProducto;
    }
    public DTOVDProducto Obtener_VProducto_O_CodigoProducto(string CodigoProducto)
    {
        DTOVDProducto dTOVDProducto = new DTOVDProducto();
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VProducto_O_CodigoProducto");
            BDSWADNETVDP.AddInParameter(dbCommand, "CodigoProducto", DbType.String, CodigoProducto);
            BDSWADNETVDP.AddInParameter(dbCommand, "EstadoProducto", DbType.Int32, EPAEstaticos.EstadoActiva);
            BDSWADNETVDP.LoadDataSet(dbCommand, dTOVDProducto, "VProducto");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dTOVDProducto;
    }
    public DTOVDProducto Obtener_VProducto_O_NombreProducto(string NombreProducto)
    {
        DTOVDProducto dtoVProducto = new DTOVDProducto();
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VProducto_O_NombreProducto");
            BDSWADNETVDP.AddInParameter(dbCommand, "NombreProducto", DbType.String, NombreProducto);
            BDSWADNETVDP.AddInParameter(dbCommand, "EstadoProducto", DbType.Int32, EPAEstaticos.EstadoActiva);
            BDSWADNETVDP.LoadDataSet(dbCommand, dtoVProducto, "VProducto");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dtoVProducto;
    }
    public void Actualizar_VProducto_A(EVProducto eVProducto)
    {
        try
        {
            Database BDSWADVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADVDP.GetStoredProcCommand("VProducto_A");
            BDSWADVDP.AddInParameter(dbCommand, "CodigoProducto", DbType.String, eVProducto.CodigoProducto);
            BDSWADVDP.AddInParameter(dbCommand, "NombreProducto", DbType.String, eVProducto.NombreProducto);
            BDSWADVDP.AddInParameter(dbCommand, "DescripcionProducto", DbType.String, eVProducto.DescripcionProducto);
            BDSWADVDP.AddInParameter(dbCommand, "PrecioUnitarioProducto", DbType.Decimal, eVProducto.PrecioUnitarioProducto);
            BDSWADVDP.AddInParameter(dbCommand, "StockProducto", DbType.Int32, eVProducto.StockProducto);
            BDSWADVDP.AddInParameter(dbCommand, "FechaModificacionProducto", DbType.DateTime, EPAEstaticos.FechaModificacion);

            BDSWADVDP.ExecuteNonQuery(dbCommand);
        }

        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void Eliminar_VProducto_E(string CodigoProducto)
    {
        try
        {
            Database BDSWADVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADVDP.GetStoredProcCommand("VProducto_E");
            BDSWADVDP.AddInParameter(dbCommand, "CodigoProducto", DbType.String, CodigoProducto);
            BDSWADVDP.AddInParameter(dbCommand, "EstadoProducto", DbType.Int32, EPAEstaticos.EstadoInactivo);
            BDSWADVDP.AddInParameter(dbCommand, "FechaModificacionProducto", DbType.DateTime, EPAEstaticos.FechaModificacion);
            BDSWADVDP.ExecuteNonQuery(dbCommand);
        }

        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion
}