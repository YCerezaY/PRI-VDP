using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CVCliente
/// </summary>
public class CVCliente
{
    #region Atributos
    private ADVCliente adVCliente;
    #endregion

    #region Constructor
    public CVCliente()
    {
        adVCliente = new ADVCliente();
    }
    #endregion

    #region Métodos públicos
    public void Insertar_VCliente_I(EVCliente eVCliente)
    {
        adVCliente.Insertar_VCliente_I(eVCliente);
    }
    public List<EVCliente> Obtener_VCliente_O_Todo()
    {
        EVCliente eVCliente;
        List<EVCliente> lstVCliente = new List<EVCliente>();
        DTOVDPCliente dtoVCliente = adVCliente.Obtener_VCliente_O_Todo();
        foreach (DTOVDPCliente.VClienteRow drVCliente in dtoVCliente.VCliente.Rows)
        {
            eVCliente = new EVCliente();
            eVCliente.CodigoCliente = drVCliente.CodigoCliente;
            eVCliente.NombreCliente = drVCliente.NombreCliente;
            eVCliente.ApellidoPaternoCliente = drVCliente.ApellidoPaternoCliente;
            eVCliente.ApellidoMaternoCliente = drVCliente.ApellidoMaternoCliente;
            eVCliente.DireccionCliente = drVCliente.DireccionCliente;
            eVCliente.TelefonoCliente = drVCliente.TelefonoCliente;
            lstVCliente.Add(eVCliente);
        }

        return lstVCliente;
    }
    public EVCliente Obtener_VCliente_O_CodigoCliente(string CodigoCliente)
    {
        EVCliente eVCliente = new EVCliente();
        DTOVDPCliente dTOVDPCliente = adVCliente.Obtener_VCliente_O_CodigoCliente(CodigoCliente);
        foreach (DTOVDPCliente.VClienteRow drVCliente in dTOVDPCliente.VCliente.Rows)
        {
            eVCliente = new EVCliente();
            eVCliente.CodigoCliente = drVCliente.CodigoCliente;
            eVCliente.NombreCliente = drVCliente.NombreCliente;
            eVCliente.ApellidoPaternoCliente = drVCliente.ApellidoPaternoCliente;
            eVCliente.ApellidoMaternoCliente = drVCliente.ApellidoMaternoCliente;
            eVCliente.DireccionCliente = drVCliente.DireccionCliente;
            eVCliente.TelefonoCliente = drVCliente.TelefonoCliente;
        }
        return eVCliente;
    }
    public List<EVCliente> Obtener_VCliente_O_ApellidoPaternoCliente(string ApellidoPaternoCliente)
    {
        EVCliente eVCliente;
        List<EVCliente> lstVCliente = new List<EVCliente>();
        DTOVDPCliente dtoVCliente = adVCliente.Obtener_VCliente_O_ApellidoPaternoCliente(ApellidoPaternoCliente);
        foreach (DTOVDPCliente.VClienteRow drVCliente in dtoVCliente.VCliente.Rows)
        {
            eVCliente = new EVCliente();
            eVCliente.CodigoCliente = drVCliente.CodigoCliente;
            eVCliente.NombreCliente = drVCliente.NombreCliente;
            eVCliente.ApellidoPaternoCliente = drVCliente.ApellidoPaternoCliente;
            eVCliente.ApellidoMaternoCliente = drVCliente.ApellidoMaternoCliente;
            eVCliente.DireccionCliente = drVCliente.DireccionCliente;
            eVCliente.TelefonoCliente = drVCliente.TelefonoCliente;
            lstVCliente.Add(eVCliente);
        }

        return lstVCliente;
    }
    public void Actualizar_VCliente_A(EVCliente eVCliente)
    {
        adVCliente.Actualizar_VCliente_A(eVCliente);
    }
    #endregion
}