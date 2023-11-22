using SWLNVDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CEmpleado
/// </summary>
public class CEmpleado
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
    public CEmpleado()
    {
        lNServicio = new LNServicio();
    }
    #endregion
    #region Metodos Públicos
    #region CEmpleado
    public void Insertar_VEmpleado_I(string CodigoEmpleado, string NombreEmpleado, string ApellidoPaternoEmpleado, string ApellidoMaternoEmpleado)
    {
        try
        {
            lNServicio.Insertar_VEmpleado_I(CodigoEmpleado, NombreEmpleado, ApellidoPaternoEmpleado, ApellidoMaternoEmpleado);

        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVEmpleado> Obtener_VEmpleado_O_Todo()
    {
        List<EVEmpleado> lstEmpleado = new List<EVEmpleado>();
        try
        {
            lstEmpleado = lNServicio.Obtener_VEmpleado_O_Todo();
        }
        catch (Exception)
        {
            throw;
        }
        return lstEmpleado;
    }
    public EVEmpleado Obtener_VEmpleado_O_CodigoEmpleado(string CodigoEmpleado)
    {
        EVEmpleado eVEmpleado = new EVEmpleado();
        try
        {
            eVEmpleado = lNServicio.Obtener_VEmpleado_O_CodigoEmpleado(CodigoEmpleado);
        }
        catch (Exception)
        {
            throw;
        }
        return eVEmpleado;
    }
    public List<EVEmpleado> Obtener_VEmpleado_O_ApellidoPaternoEmpleado(string ApellidoPaternoEmpleado)
    {
        List<EVEmpleado> lstEmpleado = new List<EVEmpleado>();
        try
        {
            lstEmpleado = lNServicio.Obtener_VEmpleado_O_ApellidoPaternoEmpleado(ApellidoPaternoEmpleado);
        }
        catch (Exception)
        {
            throw;
        }
        return lstEmpleado;
    }
    public void Actualizar_VEmpleado_A(string CodigoEmpleado, string NombreEmpleado, string ApellidoPaternoEmpleado, string ApellidoMaternoEmpleado)
    {
        try
        {
            lNServicio.Actualizar_VEmpleado_A(CodigoEmpleado, NombreEmpleado, ApellidoPaternoEmpleado, ApellidoMaternoEmpleado);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_VEmpleado_E(string CodigoEmpleado)
    {
        try
        {
            lNServicio.Eliminar_VEmpleado_E(CodigoEmpleado);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #endregion
}