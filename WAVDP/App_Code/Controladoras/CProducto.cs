using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using SWLNVDP;
using System.IO;
using System.Web.UI;
using System.ServiceModel;



/// <summary>
/// Descripción breve de CProducto
/// </summary>
public class CProducto
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
    public CProducto()
    {
        lNServicio = new LNServicio();
    }
    #endregion
    #region Metodos Públicos
    #region CProducto
    public void Insertar_VProducto_I(string CodigoProducto, string NombreProducto, string DescripcionProducto, decimal PrecioUnitarioProducto, int StockProducto)
    {
        try
        {
            lNServicio.Insertar_VProducto_I(CodigoProducto, NombreProducto, DescripcionProducto, PrecioUnitarioProducto, StockProducto);

        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVProducto> Obtener_VProducto_O_Todo()
    {
        List<EVProducto> lstProducto = new List<EVProducto>();
        try
        {
            lstProducto = lNServicio.Obtener_VProducto_O_Todo();
        }
        catch (Exception)
        {
            throw;
        }
        return lstProducto;
    }
    public EVProducto Obtener_VProducto_O_CodigoProducto(string CodigoProducto)
    {
        EVProducto eVProducto = new EVProducto();
        try
        {
            eVProducto = lNServicio.Obtener_VProducto_O_CodigoProducto(CodigoProducto);
        }
        catch (Exception)
        {
            throw;
        }
        return eVProducto;
    }
    public List<EVProducto> Obtener_VProducto_O_NombreProducto(string NombreProducto)
    {
        List<EVProducto> lstProducto = new List<EVProducto>();
        try
        {
            lstProducto = lNServicio.Obtener_VProducto_O_NombreProducto(NombreProducto);
        }
        catch (Exception)
        {
            throw;
        }
        return lstProducto;
    }
    public void Actualizar_VProducto_A(string CodigoProducto, string NombreProducto, string DescripcionProducto, decimal PrecioUnitarioProducto, int StockProducto)
    {
        try
        {
            lNServicio.Actualizar_VProducto_A(CodigoProducto, NombreProducto, DescripcionProducto, PrecioUnitarioProducto, StockProducto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_VProducto_E(string CodigoProducto)
    {
        try
        {
            lNServicio.Eliminar_VProducto_E(CodigoProducto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #endregion
}