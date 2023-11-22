using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADVEmpleado
/// </summary>
public class ADVEmpleado
{
    #region Métodos públicos
    public void Insertar_VEmpleado_I(EVEmpleado eVEmpleado)
    {
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VEmpleado_I");
            BDSWADNETVDP.AddInParameter(dbCommand, "CodigoEmpleado", DbType.String, eVEmpleado.CodigoEmpleado);
            BDSWADNETVDP.AddInParameter(dbCommand, "NombreEmpleado", DbType.String, eVEmpleado.NombreEmpleado);
            BDSWADNETVDP.AddInParameter(dbCommand, "ApellidoPaternoEmpleado", DbType.String, eVEmpleado.ApellidoPaternoEmpleado);
            BDSWADNETVDP.AddInParameter(dbCommand, "ApellidoMaternoEmpleado", DbType.String, eVEmpleado.ApellidoMaternoEmpleado);
            BDSWADNETVDP.AddInParameter(dbCommand, "Estado", DbType.Int32, EPAEstaticos.EstadoActiva);
            BDSWADNETVDP.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, EPAEstaticos.FechaRegistro);
            BDSWADNETVDP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, EPAEstaticos.FechaModificacion);
            BDSWADNETVDP.ExecuteNonQuery(dbCommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DTOVDPEmpleado Obtener_VEmpleado_O_Todo()
    {
        DTOVDPEmpleado dTOVDPEmpleado = new DTOVDPEmpleado();
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VEmpleado_O");
            BDSWADNETVDP.AddInParameter(dbCommand, "Estado", DbType.Int32, EPAEstaticos.EstadoActiva);
            BDSWADNETVDP.LoadDataSet(dbCommand, dTOVDPEmpleado, "VEmpleado");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dTOVDPEmpleado;
    }
    public DTOVDPEmpleado Obtener_VEmpleado_O_CodigoEmpleado(string CodigoEmpleado)
    {
        DTOVDPEmpleado dTOVDPEmpleado = new DTOVDPEmpleado();
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VEmpleado_O_CodigoEmpleado");
            BDSWADNETVDP.AddInParameter(dbCommand, "CodigoEmpleado", DbType.String, CodigoEmpleado);
            BDSWADNETVDP.AddInParameter(dbCommand, "Estado", DbType.Int32, EPAEstaticos.EstadoActiva);
            BDSWADNETVDP.LoadDataSet(dbCommand, dTOVDPEmpleado, "VEmpleado");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dTOVDPEmpleado;
    }

    public DTOVDPEmpleado Obtener_VEmpleado_O_ApellidoPaternoEmpleado(string ApellidoPaternoEmpleado)
    {
        DTOVDPEmpleado dtoVDPEmpleado = new DTOVDPEmpleado();
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VEmpleado_O_ApellidoPaternoEmpleado");
            BDSWADNETVDP.AddInParameter(dbCommand, "ApellidoPaternoEmpleado", DbType.String, ApellidoPaternoEmpleado);
            BDSWADNETVDP.AddInParameter(dbCommand, "Estado", DbType.Int32, EPAEstaticos.EstadoActiva);
            BDSWADNETVDP.LoadDataSet(dbCommand, dtoVDPEmpleado, "VEmpleado");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dtoVDPEmpleado;
    }

    public void Actualizar_VEmpleado_A(EVEmpleado eVEmpleado)
    {
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VEmpleado_A");
            BDSWADNETVDP.AddInParameter(dbCommand, "CodigoEmpleado", DbType.String, eVEmpleado.CodigoEmpleado);
            BDSWADNETVDP.AddInParameter(dbCommand, "NombreEmpleado", DbType.String, eVEmpleado.NombreEmpleado);
            BDSWADNETVDP.AddInParameter(dbCommand, "ApellidoPaternoEmpleado", DbType.String, eVEmpleado.ApellidoPaternoEmpleado);
            BDSWADNETVDP.AddInParameter(dbCommand, "ApellidoMaternoEmpleado", DbType.String, eVEmpleado.ApellidoMaternoEmpleado);
            BDSWADNETVDP.AddInParameter(dbCommand, "Estado", DbType.Int32, EPAEstaticos.EstadoActiva);
            BDSWADNETVDP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, EPAEstaticos.FechaModificacion);
            BDSWADNETVDP.ExecuteNonQuery(dbCommand);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void Eliminar_VEmpleado_E(string CodigoEmpleado)
    {
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VEmpleado_E");
            BDSWADNETVDP.AddInParameter(dbCommand, "CodigoEmpleado", DbType.String, CodigoEmpleado);
            BDSWADNETVDP.AddInParameter(dbCommand, "Estado", DbType.Int32, EPAEstaticos.EstadoInactivo);
            BDSWADNETVDP.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, EPAEstaticos.FechaModificacion);
            BDSWADNETVDP.ExecuteNonQuery(dbCommand);

        }
        catch  (Exception ex) 
        {
            throw ex;
        }
    }
    #endregion    
}