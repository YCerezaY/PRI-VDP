using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADVCLiente
/// </summary>
public class ADVCliente
{
    #region Métodos públicos
    public void Insertar_VCliente_I(EVCliente eVCLiente)
    {
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VCliente_I");
            BDSWADNETVDP.AddInParameter(dbCommand, "CodigoCliente", DbType.String, eVCLiente.CodigoCliente);
            BDSWADNETVDP.AddInParameter(dbCommand, "NombreCliente", DbType.String, eVCLiente.NombreCliente);
            BDSWADNETVDP.AddInParameter(dbCommand, "ApellidoPaternoCliente", DbType.String, eVCLiente.ApellidoPaternoCliente);
            BDSWADNETVDP.AddInParameter(dbCommand, "ApellidoMaternoCliente", DbType.String, eVCLiente.ApellidoMaternoCliente);
            BDSWADNETVDP.AddInParameter(dbCommand, "DireccionCliente", DbType.String, eVCLiente.DireccionCliente);
            BDSWADNETVDP.AddInParameter(dbCommand, "TelefonoCliente", DbType.Int32, eVCLiente.TelefonoCliente);
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
    public DTOVDPCliente Obtener_VCliente_O_Todo()
    {
        DTOVDPCliente dtoVCliente = new DTOVDPCliente();
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VCliente_O");
            BDSWADNETVDP.AddInParameter(dbCommand, "Estado", DbType.Int32, EPAEstaticos.EstadoActiva);
            BDSWADNETVDP.LoadDataSet(dbCommand, dtoVCliente, "VCliente");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dtoVCliente;
    }
    public DTOVDPCliente Obtener_VCliente_O_CodigoCliente(string CodigoCliente)
    {
        DTOVDPCliente dtoVCliente = new DTOVDPCliente();
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VCliente_O_CodigoCliente");
            BDSWADNETVDP.AddInParameter(dbCommand, "CodigoCliente", DbType.String, CodigoCliente);
            BDSWADNETVDP.AddInParameter(dbCommand, "Estado", DbType.Int32, EPAEstaticos.EstadoActiva);
            BDSWADNETVDP.LoadDataSet(dbCommand, dtoVCliente, "VCliente");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dtoVCliente;
    }
    public DTOVDPCliente Obtener_VCliente_O_ApellidoPaternoCliente(string ApellidoPaternoCliente)
    {
        DTOVDPCliente dtoVCliente = new DTOVDPCliente();
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VCliente_O_ApellidoPaternoCliente");
            BDSWADNETVDP.AddInParameter(dbCommand, "ApellidoPaternoCliente", DbType.String, ApellidoPaternoCliente);
            BDSWADNETVDP.AddInParameter(dbCommand, "Estado", DbType.Int32, EPAEstaticos.EstadoActiva);
            BDSWADNETVDP.LoadDataSet(dbCommand, dtoVCliente, "VCliente");
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dtoVCliente;
    }
    public void Actualizar_VCliente_A(EVCliente eVCLiente)
    {
        try
        {
            Database BDSWADNETVDP = SBaseDatos.BDSWADVDP;
            DbCommand dbCommand = BDSWADNETVDP.GetStoredProcCommand("VCliente_A");
            BDSWADNETVDP.AddInParameter(dbCommand, "CodigoCliente", DbType.String, eVCLiente.CodigoCliente);
            BDSWADNETVDP.AddInParameter(dbCommand, "NombreCliente", DbType.String, eVCLiente.NombreCliente);
            BDSWADNETVDP.AddInParameter(dbCommand, "ApellidoPaternoCliente", DbType.String, eVCLiente.ApellidoPaternoCliente);
            BDSWADNETVDP.AddInParameter(dbCommand, "ApellidoMaternoCliente", DbType.String, eVCLiente.ApellidoMaternoCliente);
            BDSWADNETVDP.AddInParameter(dbCommand, "DireccionCliente", DbType.String, eVCLiente.DireccionCliente);
            BDSWADNETVDP.AddInParameter(dbCommand, "TelefonoCliente", DbType.Int32, eVCLiente.TelefonoCliente);
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
    #endregion    
}