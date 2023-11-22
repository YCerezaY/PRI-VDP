using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CRProducto
/// </summary>
public class CVProducto
{
    #region Metodo privado
    private ADVProducto adVProducto;
    #endregion
    #region Metodos publicos
    public CVProducto()
    {
        adVProducto = new ADVProducto();
    }

    public void Insertar_VPorducto_I(EVProducto eVproducto)
    {
        adVProducto.Insertar_VProducto_I(eVproducto);
    }
    public List<EVProducto> Obtener_VProducto_O_Todo()
    {
        EVProducto eVProducto;
        List<EVProducto> lstVProducto = new List<EVProducto>();
        DTOVDProducto dTOVDProducto = adVProducto.Obtener_VProducto_O_Todo();
        foreach (DTOVDProducto.VProductoRow drVProducto in dTOVDProducto.VProducto.Rows)
        {
            eVProducto = new EVProducto();
            eVProducto.CodigoProducto = drVProducto.CodigoProducto;
            eVProducto.NombreProducto = drVProducto.NombreProducto;
            eVProducto.DescripcionProducto = drVProducto.DescripcionProducto;
            eVProducto.PrecioUnitarioProducto = drVProducto.PrecioUnitarioProducto;
            eVProducto.StockProducto = drVProducto.StockProducto;
            lstVProducto.Add(eVProducto);
        }

        return lstVProducto;
    }

    public EVProducto Obtener_VProducto_O_CodigoProducto(string CodigoProducto)
    {
        EVProducto eVProducto = new EVProducto();
        DTOVDProducto dTOVDPEmpleado = adVProducto.Obtener_VProducto_O_CodigoProducto(CodigoProducto);
        foreach (DTOVDProducto.VProductoRow drVProducto in dTOVDPEmpleado.VProducto.Rows)
        {
            eVProducto = new EVProducto();
            eVProducto.CodigoProducto = drVProducto.CodigoProducto;
            eVProducto.NombreProducto = drVProducto.NombreProducto;
            eVProducto.DescripcionProducto = drVProducto.DescripcionProducto;
            eVProducto.PrecioUnitarioProducto = drVProducto.PrecioUnitarioProducto;
            eVProducto.StockProducto = drVProducto.StockProducto;
        }
        return eVProducto;
    }

    public List<EVProducto> Obtener_VProducto_O_NombreProducto(string NombreProducto)
    {
        EVProducto eVProducto;
        List<EVProducto> lstVProducto = new List<EVProducto>();
        DTOVDProducto dtoVProducto = adVProducto.Obtener_VProducto_O_NombreProducto(NombreProducto);
        foreach (DTOVDProducto.VProductoRow drVProducto in dtoVProducto.VProducto.Rows)
        {
            eVProducto = new EVProducto();
            eVProducto.CodigoProducto = drVProducto.CodigoProducto;
            eVProducto.NombreProducto = drVProducto.NombreProducto;
            eVProducto.DescripcionProducto = drVProducto.DescripcionProducto;
            eVProducto.PrecioUnitarioProducto = drVProducto.PrecioUnitarioProducto;
            eVProducto.StockProducto = drVProducto.StockProducto;
            lstVProducto.Add(eVProducto);
        }

        return lstVProducto;
    }

    public void Actualizar_VProducto_A(EVProducto eVProducto)
    {
        adVProducto.Actualizar_VProducto_A(eVProducto);
    }
    public void Eliminar_VProducto_E(string codigoProducto)
    {
        adVProducto.Eliminar_VProducto_E(codigoProducto);
    }
    #endregion
}