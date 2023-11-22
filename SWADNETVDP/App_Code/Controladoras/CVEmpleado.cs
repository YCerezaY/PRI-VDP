using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CVEmpleado
/// </summary>
public class CVEmpleado
{
    #region Atributos
    private ADVEmpleado aDVEmpleado;
    #endregion

    #region Constructor
    public CVEmpleado()
    {
        aDVEmpleado = new ADVEmpleado();
    }
    #endregion

    #region Métodos públicos
    public void Insertar_VEmpleado_I(EVEmpleado eVEmpleado)
    {
        aDVEmpleado.Insertar_VEmpleado_I(eVEmpleado);
    }
    public List<EVEmpleado> Obtener_VEmpleado_O_Todo()
    {
        EVEmpleado eVEmpleado;
        List<EVEmpleado> lstVEmpleado = new List<EVEmpleado>();
        DTOVDPEmpleado dTOVDPEmpleado = aDVEmpleado.Obtener_VEmpleado_O_Todo();
        foreach (DTOVDPEmpleado.VEmpleadoRow drVEmpleado in dTOVDPEmpleado.VEmpleado.Rows)
        {
            eVEmpleado = new EVEmpleado();
            eVEmpleado.CodigoEmpleado = drVEmpleado.CodigoEmpleado;
            eVEmpleado.NombreEmpleado = drVEmpleado.NombreEmpleado;
            eVEmpleado.ApellidoPaternoEmpleado = drVEmpleado.ApellidoPaternoEmpleado;
            eVEmpleado.ApellidoMaternoEmpleado = drVEmpleado.ApellidoMaternoEmpleado;
            lstVEmpleado.Add(eVEmpleado);
        }

        return lstVEmpleado;
    }
    public EVEmpleado Obtener_VEmpleado_O_CodigoEmpleado(string CodigoEmpleado)
    {
        EVEmpleado eVEmpleado = new EVEmpleado();
        DTOVDPEmpleado dTOVDPEmpleado = aDVEmpleado.Obtener_VEmpleado_O_CodigoEmpleado(CodigoEmpleado);
        foreach (DTOVDPEmpleado.VEmpleadoRow drVEmpleado in dTOVDPEmpleado.VEmpleado.Rows)
        {
            eVEmpleado = new EVEmpleado();
            eVEmpleado.CodigoEmpleado = drVEmpleado.CodigoEmpleado;
            eVEmpleado.NombreEmpleado = drVEmpleado.NombreEmpleado;
            eVEmpleado.ApellidoPaternoEmpleado = drVEmpleado.ApellidoPaternoEmpleado;
            eVEmpleado.ApellidoMaternoEmpleado = drVEmpleado.ApellidoMaternoEmpleado;
        }
        return eVEmpleado;
    }
    public List<EVEmpleado> Obtener_VEmpleado_O_ApellidoPaternoEmpleado(string ApellidoPaternoEmpleado)
    {
        EVEmpleado eVEmpleado;
        List<EVEmpleado> lstVEmpleado = new List<EVEmpleado>();
        DTOVDPEmpleado dtoVDPEmpleado = aDVEmpleado.Obtener_VEmpleado_O_ApellidoPaternoEmpleado(ApellidoPaternoEmpleado);
        foreach (DTOVDPEmpleado.VEmpleadoRow drVEmpleado in dtoVDPEmpleado.VEmpleado.Rows)
        {
            eVEmpleado = new EVEmpleado();
            eVEmpleado.CodigoEmpleado = drVEmpleado.CodigoEmpleado;
            eVEmpleado.NombreEmpleado = drVEmpleado.NombreEmpleado;
            eVEmpleado.ApellidoPaternoEmpleado = drVEmpleado.ApellidoPaternoEmpleado;
            eVEmpleado.ApellidoMaternoEmpleado = drVEmpleado.ApellidoMaternoEmpleado;
            lstVEmpleado.Add(eVEmpleado);
        }

        return lstVEmpleado;
    }
    public void Actualizar_VEmpleado_A(EVEmpleado eVEmpleado)
    {
        aDVEmpleado.Actualizar_VEmpleado_A(eVEmpleado);
    }
    public void Eliminar_VEmpleado_E(string CodigoEmpleado)
    {
        aDVEmpleado.Eliminar_VEmpleado_E(CodigoEmpleado);
    }
    #endregion
}