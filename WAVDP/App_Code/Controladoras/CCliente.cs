using SWLNVDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CCliente
/// </summary>
public class CCliente
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
    public CCliente()
    {
        lNServicio = new LNServicio();
    }
    #endregion
    #region Metodos Públicos
    #region CCliente
    public void Insertar_VCliente_I(string CodigoCliente, string NombreCliente, string ApellidoPaternoCliente, string ApellidoMaternoCliente, string DireccionCliente, int TelefonoCliente)
    {
        try
        {
            lNServicio.Insertar_VCliente_I(CodigoCliente, NombreCliente, ApellidoPaternoCliente, ApellidoMaternoCliente, DireccionCliente, TelefonoCliente);

        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVCliente> Obtener_VCliente_O_Todo()
    {
        List<EVCliente> lstCliente = new List<EVCliente>();
        try
        {
            lstCliente = lNServicio.Obtener_VCliente_O_Todo();
        }
        catch (Exception)
        {
            throw;
        }
        return lstCliente;
    }
    public EVCliente Obtener_VCliente_O_CodigoCliente(string CodigoCliente)
    {
        EVCliente eVCliente = new EVCliente();
        try
        {
            eVCliente = lNServicio.Obtener_VCliente_O_CodigoCliente(CodigoCliente);
        }
        catch (Exception)
        {
            throw;
        }
        return eVCliente;
    }
    public List<EVCliente> Obtener_VCliente_O_ApellidoPaternoCliente(string ApellidoPaternoCliente)
    {
        List<EVCliente> lstCliente = new List<EVCliente>();
        try
        {
            lstCliente = lNServicio.Obtener_VCliente_O_ApellidoPaternoCliente(ApellidoPaternoCliente);
        }
        catch (Exception)
        {
            throw;
        }
        return lstCliente;
    }
    public void Actualizar_VCliente_A(string CodigoCliente, string NombreCliente, string ApellidoPaternoCliente, string ApellidoMaternoCliente, string DireccionCliente, int TelefonoCliente)
    {
        try
        {
            lNServicio.Actualizar_VCliente_A(CodigoCliente, NombreCliente, ApellidoPaternoCliente, ApellidoMaternoCliente, DireccionCliente, TelefonoCliente);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #endregion
}